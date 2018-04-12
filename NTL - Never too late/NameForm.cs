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

namespace NTL___Never_too_late
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }
        public static string LessonName;

        private void button1_Click(object sender, EventArgs e)
        {
            checkName();
        }
        private void lessonName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkName();
            }
        }
        private void checkName()
        {
            if (lessonName.Text == "")
            {
                MessageBox.Show("Wpisz nazwę lekcji", "Ups..");
            } else
            {
                string path = @"Lessons\" + lessonName.Text + ".dat";
                if (File.Exists(path))
                {
                    DialogResult dialogResult = MessageBox.Show("Lekcja o podanej nazwie istnieje. Czy chcesz wrócić do menu głownego?", "Ups..", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Close();
                    } else if (dialogResult == DialogResult.No)
                    {
                        lessonName.Clear();
                    }
                } else
                {
                    createAddForm();
                }
            }
        }
        private void createAddForm()
        {
            AddForm addWords = new AddForm();
            addWords.Show();
            LessonName = lessonName.Text;
            this.Close();
        }
    }
}
