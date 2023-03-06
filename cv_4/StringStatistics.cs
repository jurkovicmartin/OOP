using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace cv_4
{
    internal class StringStatistics
    {
        private string my_string { get; set; }
        public StringStatistics(string text)
        {
            my_string = text;
        }



        /*public IEnumerable<string> Words => my_string.Split(new char[] { ' ', ',', '.', '!', '\n', '(', ')', '?', '/' }, StringSplitOptions.RemoveEmptyEntries);

        public int NumberOfWords => Words.Count();

        public IEnumerable<string> AlhabeticWords => Words.OrderBy(w => w);

        public IEnumerable<string> SmallestWords => Words.GroupBy(w => w.Length).MinBy(w => w.Key);

        public IEnumerable<string> LongestWords => Words.GroupBy(w => w.Length).MaxBy(w => w.Key);

        public IEnumerable<string> MostFrequentWords => Words.GroupBy(w => w).MaxBy(w => w.Count());*/

        public int NumberOfWords()
        {
            char[] delimiterChars = { ' ', '\n' };
            return my_string.Split(delimiterChars).Length;
        }


            public int NumberOfLines()
        {
            int lines = 0;

            for (int i = 0; i < my_string.Length; i++)
            {
                if (my_string[i] == '\n')
                {
                    lines++;
                }
            }
            lines++;
            return lines;
        }

        public int NumberOfSentences()
        {
            char[] delimiterChars = { '.', '?', '!' };
            string text = my_string.Replace("\n", "").Replace(" ", "");
            string[] row = text.Split(delimiterChars);
            int counter = 0;
            for (int i = 0; i < row.Length - 2; i++)
            {
                if (i == 0 && Char.IsUpper(row[i][0]))
                {
                    counter++;
                }
                if (Char.IsUpper(row[i + 1][0]))
                {
                    counter++;
                }
            }
            return counter;
        }

        public ArrayList MostCommonWord()
        {
            var dict = new Dictionary<string, int>();
            ArrayList commonWord = new ArrayList();
            string text = my_string.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "");
            string[] words = text.Split(' ');
            int ocurencies = 0;
            foreach (var thing in words)
            {
                if (dict.ContainsKey(thing))
                {
                    dict[thing]++;
                }
                else
                {
                    dict.Add(thing, 1);
                }
            }
            foreach (var key in dict)
            {
                if (key.Value > ocurencies)
                {
                    ocurencies = key.Value;
                    commonWord.Clear();
                    commonWord.Add(key.Key);
                }
                else if (key.Value == ocurencies)
                {
                    commonWord.Add(key.Key);
                }
            }
            return commonWord;
        }

        public ArrayList LongestWord()
        {
            ArrayList longestWord = new ArrayList();
            string text = my_string.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "");
            string[] words = text.Split(' ');
            int biggestLength = 0;

            foreach (var word in words)
            {
                if (word.Length > biggestLength)
                {
                    biggestLength = word.Length;
                    longestWord.Clear();
                    longestWord.Add(word);
                }
                else if (word.Length == biggestLength)
                {
                    longestWord.Add(word);
                }
            }
            return longestWord;
        }

        public ArrayList ShortestWord()
        {
            ArrayList shortestWord = new ArrayList();
            string text = my_string.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "");
            string[] words = text.Split(' ');
            int shortestLength = int.MaxValue;

            foreach (var word in words)
            {
                if (word.Length < shortestLength)
                {
                    shortestLength = word.Length;
                    shortestWord.Clear();
                    shortestWord.Add(word);
                }
                else if (word.Length == shortestLength)
                {
                    shortestWord.Add(word);
                }
            }
            return shortestWord;
        }

        public ArrayList SortedArray()
        {
            ArrayList wordList = new ArrayList();
            string text = my_string.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "");
            string[] words = text.Split(' ');
            foreach (var thing in words)
            {
                wordList.Add(thing);
            }
            wordList.Sort();
            return wordList;
        }
        public StringBuilder PrintArrayList(ArrayList arrlist)
        {
            StringBuilder text = new StringBuilder();
            if (arrlist.Count == 1)
            {
                text.Append(arrlist[0]);
            }
            else
            {
                foreach (var item in arrlist)
                {
                    text.Append(item).Append(", ");
                }
            }
            return text;
        }


        public override string ToString()
        {
            return this.my_string;
        }
    }
}
