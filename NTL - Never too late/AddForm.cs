using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace NTL___Never_too_late
{
    public partial class AddForm : Form
    {
        private Vocabulary vocabulary;

        public AddForm()
        {
            InitializeComponent();
            vocabulary = new Vocabulary();
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            addWord();
        }
        private void englishWord_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                addWord();
            }
        }
        private void addWord()
        {
            string polWord = polishWord.Text.ToLower().TrimEnd(' ');
            string engWord = englishWord.Text.ToLower().TrimEnd(' ');

            if (polWord == "" || engWord == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }
            else
            {
                Word word = new Word(engWord, polWord);
                vocabulary.addWord(word);
                polishWord.Clear();
                englishWord.Clear();
                polishWord.Focus();
            }
        }
        private void saveLesson_Click(object sender, EventArgs e)
        {
            string path = @"Lessons\" + NameForm.LessonName + ".dat";
            using (Stream output = File.Create(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, vocabulary);
            }
            this.Close();
        }
    }
}
