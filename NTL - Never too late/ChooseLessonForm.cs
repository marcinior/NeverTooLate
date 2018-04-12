using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTL___Never_too_late
{
    public partial class ChooseLessonForm : Form
    {
        public ChooseLessonForm()
        {
            InitializeComponent();
            nickBox.Select();
        }
        public static string LessonName;
        public static string LessonType;
        public static string Nick;

        private void chooseLessonButton_Click(object sender, EventArgs e)
        {
            if (!( String.IsNullOrEmpty(this.lessonsComboBox.Text) ||
                String.IsNullOrEmpty(this.lessonTypeComboBox2.Text) ||
                String.IsNullOrEmpty(this.lessonTypeComboBox.Text) ||
                String.IsNullOrEmpty(this.nickBox.Text) ))
            {
                LessonName = this.lessonsComboBox.Text;
                LessonType = this.lessonTypeComboBox2.Text;
                Nick = this.nickBox.Text;
                lessonType type;
                Enum.TryParse<lessonType>(this.lessonTypeComboBox.Text, false, out type);

                switch (type)
                {
                    case lessonType.test:
                        Test testForm = new Test();
                        testForm.Show();
                        this.Close();
                        break;
                    case lessonType.nauka:
                        LearningForm learningForm = new LearningForm();
                        learningForm.Show();
                        this.Close();
                        break;
                }
            } else
            {
                MessageBox.Show("Uzupełnij wszystkie pola", "Ups..");
            }

        }

    }
}
