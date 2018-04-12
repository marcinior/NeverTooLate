using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace NTL___Never_too_late
{
    class FileManager
    {
        public void CreateFile(string name)
        {
            string path = Directory.GetCurrentDirectory() + @"\Results\" + name + ".txt";
            File.Create(path).Close();
        }
        public void AddToFile(string nick, double result, string mark, string path)
        {
            string scoreData = nick + ":" + result + ":" + mark;
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(scoreData);
            }

        }
        public bool IsExists(string path)
        {
            bool exist = System.IO.File.Exists(path) ? true : false;
            return exist;
        }
        public ArrayList GetAllLines(string path)
        {
            StreamReader reader = new StreamReader(path);
            ArrayList lines = new ArrayList();

            while (!reader.EndOfStream)
            {
                lines.Add(reader.ReadLine());
            }
            reader.Close();
            return lines;
        }
    }
}
