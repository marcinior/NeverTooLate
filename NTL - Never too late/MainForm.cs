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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
        private void newLessonButtonClicked(object sender, EventArgs e)
        {
            NameForm getName = new NameForm();
            getName.Show();
        }

        private void loadLessonButtonClicked(object sender, EventArgs e)
        {
            ChooseLessonForm chooseLessonForm = new ChooseLessonForm();
            chooseLessonForm.Show();
            chooseLessonForm.lessonsComboBox = new System.Windows.Forms.ComboBox();
            chooseLessonForm.SuspendLayout();
            chooseLessonForm.Controls.Add(chooseLessonForm.lessonsComboBox);

            chooseLessonForm.lessonsComboBox.FormattingEnabled = true;
            chooseLessonForm.lessonsComboBox.Location = new System.Drawing.Point(52, 127);
            chooseLessonForm.lessonsComboBox.Name = "lessons";
            chooseLessonForm.lessonsComboBox.Size = new System.Drawing.Size(168, 21);
            chooseLessonForm.lessonsComboBox.TabIndex = 0;
            chooseLessonForm.lessonsComboBox.Font = new System.Drawing.Font("PT Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 238 ) ));

            foreach (var val in getLessonNames())
            {
                string name = val.Substring(0, val.Length - 4);
                chooseLessonForm.lessonsComboBox.Items.Add(name);
            }

            this.WindowState = FormWindowState.Minimized;
        }
        private string[] getLessonNames()
        {
            string[] lessons = Directory.GetFiles(@"Lessons\")
            .Select(Path.GetFileName)
            .ToArray();
            return lessons;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}
