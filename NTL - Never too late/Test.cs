using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NTL___Never_too_late
{
    public partial class Test : Form
    {
        private Vocabulary vocabulary;
        private static sbyte counter;
        private static int correct;
        private static sbyte incorrect;
        private string currentWord = "";
        private ChooseLessonForm.lessonType2 type;

        public Test()
        {
            InitializeComponent();
            counter = 0;
            correct = 0;
            incorrect = 0;
            BinaryFormatter formatter = new BinaryFormatter();
            string path = @"Lessons\" + ChooseLessonForm.LessonName + ".dat";

            using (Stream input = File.OpenRead(path))
            {
                vocabulary = (Vocabulary)formatter.Deserialize(input);
            }
            vocabulary.shuffle();

            Enum.TryParse<ChooseLessonForm.lessonType2>(ChooseLessonForm.LessonType, false, out type);
            getWord(type);
            this.textQuestCount.Text = vocabulary.getLength().ToString();
        }

        private void getWord(ChooseLessonForm.lessonType2 type)
        {
            switch (type)
            {
                case ChooseLessonForm.lessonType2.ANG_POL:
                    try
                    {
                        currentWord = vocabulary.getValue(counter).Eng.ToString();
                        this.toTranslateBox.Text = currentWord;
                        this.progressBar1.Value = Convert.ToInt32(counter * 100.0 / vocabulary.getLength());
                    }
                    catch(ArgumentOutOfRangeException e)
                    {
                        markTest();
                    }
                    break;
                case ChooseLessonForm.lessonType2.POL_ANG:
                    try
                    {
                        currentWord = vocabulary.getValue(counter).Pol.ToString();
                        this.toTranslateBox.Text = currentWord;
                        this.progressBar1.Value = Convert.ToInt32(counter * 100.0 / vocabulary.getLength());
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        markTest();
                    }
                    break;
            }
        }
        private void checkAnswer(string answer)
        {
            if (vocabulary.getValue(counter).CheckAnswer(answer, type))
            {
                correct++;
                this.answerBox.Clear();
                this.correctAnswerBox.Text = "";
            }else
            {
                incorrect++;
                this.correctAnswerBox.Text = vocabulary.getValue(counter).GetCorrectAnswer(type);
                this.correctAnswerBox.ForeColor = Color.Green;
                this.answerBox.Clear();
                this.answerBox.Focus();
 
            }

            correctBox.Text = correct.ToString();
            incorrectBox.Text = incorrect.ToString();
            counter++;
        }
        private void markTest()
        {
            double result = Math.Round(((Convert.ToDouble(correct) / vocabulary.getLength())*100)); 
            string mark = "";

            if (result < 50)
            {
                mark = "niedostateczny";
            }
            else if (result >= 50 && result < 60)
            {
                mark = "dopuszczający";
            }
            else if (result >= 60 && result < 70)
            {
                mark = "dostateczny";
            }
            else if (result >= 70 && result < 80)
            {
                mark = "dobry";
            }
            else if (result >= 80 && result < 90)
            {
                mark = "bardzo dobry";
            }
            else if(result >= 90)
            {
                mark = "celujący";
            }

            DialogResult dialogResult = MessageBox.Show($"Poprawnych odpowiedzi: {correct}\nNiepoprawnych odpowiedzi: {incorrect}\nWynik procentowy: {result}%\nOcena: {mark}\nCzy chcesz zapisać wynik?", "Wyniki testu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string path = Directory.GetCurrentDirectory() + @"\Results\" + ChooseLessonForm.LessonName.ToLower() + ".txt";
                FileManager manager = new FileManager();
                if (manager.IsExists(path))
                {
                    manager.AddToFile(ChooseLessonForm.Nick, result, mark,path);
                }
                else
                {
                    manager.CreateFile(ChooseLessonForm.LessonName.ToLower());
                    manager.AddToFile(ChooseLessonForm.Nick, result, mark,path);
                }
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.answerBox.Text))
            {
                string answer = this.answerBox.Text.ToLower().TrimEnd(' ');
                checkAnswer(answer);
                answerBox.Focus();
            }else
            {
                MessageBox.Show("Wpisz odpowiedź, aby kontynuować", "Ups..");
            }

            if (counter < vocabulary.getLength())
            {
                getWord(type);
            }else
            {
                markTest();
                counter = 0;
                correct = 0;
                incorrect = 0;
            }
        }

        private void answerBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                checkButton_Click(sender, e);
            }
        }
    }
}
