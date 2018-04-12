using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTL___Never_too_late
{
    [Serializable]
    class Word
    {
        public string Eng
        {
            get;
            private set;
        }

        public string Pol
        {
            get;
            private set;
        }

        public Word(string eng,string pol)
        {
            this.Eng = eng;
            this.Pol = pol;
        }

        public bool CheckAnswer(string answer,ChooseLessonForm.lessonType2 type){
            switch (type)
            {
                case ChooseLessonForm.lessonType2.ANG_POL:

                    if (this.Pol == answer) return true;
                    else return false;

                case ChooseLessonForm.lessonType2.POL_ANG:

                    if (this.Eng == answer) return true;
                    else return false;

                default: return false;
            }
        }
        public string GetCorrectAnswer(ChooseLessonForm.lessonType2 type)
        {
            switch (type)
            {
                case ChooseLessonForm.lessonType2.ANG_POL:
                    return this.Pol;
                case ChooseLessonForm.lessonType2.POL_ANG:
                    return this.Eng;
                default:
                    return "";
            }
        }
        
    }
}
