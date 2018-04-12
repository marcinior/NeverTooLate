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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            completeComboBox();         
        }
        private void completeComboBox()
        {
            foreach (var val in getLessonNames())
            {
                string name = val.Substring(0, val.Length - 4);
                this.deleteLessonComboBox.Items.Add(name);
                this.chooseRecordComboBox.Items.Add(name);
            }
        }
        private string[] getLessonNames()
        {
            string[] lessons = Directory.GetFiles(@"Lessons\")
            .Select(Path.GetFileName)
            .ToArray();
            return lessons;
        }

        private void deleteLessonButton_Click(object sender, EventArgs e)
        {
            if (this.deleteLessonComboBox.Text != "")
            {
                string name = this.deleteLessonComboBox.Text;
                string path = Directory.GetCurrentDirectory() + @"\Lessons\" + name + ".dat";
                File.Delete(path);
                this.deleteLessonComboBox.Items.Remove(name);
                this.chooseRecordComboBox.Items.Remove(name);
                MessageBox.Show("Usunięto lekcję");
            }
            else
            {
                MessageBox.Show("Wybierz lekcję do usunięcia","Ups..");
            }
        }

        private void showRecords_Click(object sender, EventArgs e)
        {
            

            if (this.chooseRecordComboBox.Text != "")
            {
                string name = this.chooseRecordComboBox.Text;
                string path = Directory.GetCurrentDirectory() + @"\Results\" + name + ".txt";
                string[][] results;
                int counter = 0;

                try
                {
                    StreamReader reader = new StreamReader(path);
                    int length = File.ReadAllLines(path).Count();
                    results = new string[length][];
                    counter = 0;

                    while (!reader.EndOfStream)
                    {
                        results[counter] = reader.ReadLine().Split(':');
                        counter++;
                    }
                    reader.Close();

                string statement = "";
                int j = results.GetLength(0);

                    while (j > 0)
                    {
                        for (int i = 1; i < j; i++)
                        {
                            Compare(ref results[i-1], ref results[i]);
                        }
                        j--;
                    }

                counter = 0;
                byte topCounter = 1;

                foreach (var x in results)
                {
                    foreach (var y in x)
                    {
                        if (topCounter <= 10)
                        {
                            switch (counter)
                            {
                                case 0:
                                    statement += topCounter + ". Nick: " + y;
                                    break;
                                case 1:
                                    statement += " Wynik: " + y + "%";
                                    break;
                                case 2:
                                    statement += " Ocena: " + y + "\n";
                                    break;
                            }
                            counter++;
                            if (counter == 3)
                            {
                                counter = 0;
                                topCounter++;
                            }
                        }
                    }
                }
                MessageBox.Show(statement, "Najlepsze wyniki");
            }
             catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Nie ma jeszcze wyników");
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Nie ma jeszcze wyników");
                }
            }
            else
            {
                MessageBox.Show("Wybierz lekcję, aby zobaczyć wyniki", "Ups..");
            }
        }
        public void Compare(ref string[] x,ref string[] y)
        {
            int val1 = Convert.ToInt32(x[1]);
            int val2 = Convert.ToInt32(y[1]);

            if (val1 < val2)
            {
                string[] temp = x;
                x = y;
                y = temp;
            }
        }
    }
}
