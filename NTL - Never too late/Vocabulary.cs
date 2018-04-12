using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NTL___Never_too_late
{
    [Serializable]
    class Vocabulary
    {
        private ArrayList words;

        public Vocabulary()
        {
            this.words = new ArrayList();
        }

        public void addWord(Word word)
        {
            words.Add(word);
        }

        public void remove(Word word)
        {
            words.Remove(word);
        }

        public void clear()
        {
            words.Clear();
        }

        public bool contains(Word word)
        {
            if (words.Contains(word))
                return true;
            else
                return false;
        }

        public int getLength()
        {
            return words.Count;
        }

        public Word getValue(int index)
        {
            return (Word)this.words[index];
        }

        public ArrayList getList()
        {
            return words;
        }
        public void shuffle()
        {
            Random rand = new Random();

            for (int i = 0; i < this.getLength() - 1; i++)
            {
                int randomPosition = rand.Next(i + 1, this.getLength() - 1);
                swap(i, randomPosition);
            }
        }

        private void swap(int a, int b)
        {
            Word temp = (Word)words[a];
            this.words[a] = (Word)words[b];
            this.words[b] = temp;
        }
    }
}

