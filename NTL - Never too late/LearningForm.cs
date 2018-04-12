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
using System.Threading;

namespace NTL___Never_too_late
{
    public partial class LearningForm : Form
    {
        private Vocabulary vocabulary;
        private static sbyte counter;
        private ChooseLessonForm.lessonType2 type;
        private Thread thread;

        public LearningForm()
        {
            InitializeComponent();
            counter = 0;
            BinaryFormatter formatter = new BinaryFormatter();
            string path = @"Lessons\" + ChooseLessonForm.LessonName + ".dat";

            using (Stream input = File.OpenRead(path))
            {
                vocabulary = (Vocabulary)formatter.Deserialize(input);
            }
            vocabulary.shuffle();

            Enum.TryParse<ChooseLessonForm.lessonType2>(ChooseLessonForm.LessonType, false, out type);
            
        }
        private void getWord(object obj)
        {
            string word="";
            string translate="";
            this.translateTextBox.Text = translate;

            switch (type)
            {
                case ChooseLessonForm.lessonType2.ANG_POL:
                    try
                    {
                        word = vocabulary.getValue(counter).Eng.ToString();
                        translate = vocabulary.getValue(counter).Pol.ToString();                        
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        counter = 0;
                        vocabulary.shuffle();
                    }
                    this.wordTextBox.Text = word;
                    System.Threading.Thread.Sleep(5000);
                    this.translateTextBox.Text = translate;
                    System.Threading.Thread.Sleep(5000);
                    break;
                case ChooseLessonForm.lessonType2.POL_ANG:
                    try
                    {
                        word = vocabulary.getValue(counter).Pol.ToString();
                        translate = vocabulary.getValue(counter).Eng.ToString();                       
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        counter = 0;
                        vocabulary.shuffle();
                    }
                    this.wordTextBox.Text = word;
                    System.Threading.Thread.Sleep(5000);
                    this.translateTextBox.Text = translate;
                    System.Threading.Thread.Sleep(5000);
                    break;
            }
            counter++;
            getWord(type);
        }

        private void endLearningButton_Click(object sender, EventArgs e)
        {
            thread.Abort();
            this.Close();
        }

        private void LearningForm_Load(object sender, EventArgs e)
        {
            thread = new Thread(getWord);
            thread.Start(type);
        }

    }
}
