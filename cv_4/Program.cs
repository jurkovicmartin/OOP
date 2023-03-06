using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_4
{
    internal class Run
    {
        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
 + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
 + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
 + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
 + "posledni veta!";

            StringStatistics text = new StringStatistics(testovaciText);

            Console.WriteLine("Number of words: " + text.NumberOfWords());
            Console.WriteLine("Number of lines: " + text.NumberOfLines());
            Console.WriteLine("Number of sentences: " + text.NumberOfSentences());
            //Console.WriteLine("Number of sentences: " + text.NumberOfSentences());
            //Console.WriteLine("Alphabetic order: " + string.Join(',', text.AlhabeticWords));
            //Console.WriteLine("Smallest words: " + string.Join(',', text.SmallestWords));
            //Console.WriteLine("Longest words: " + string.Join(',', text.LongestWords));
            //Console.WriteLine("Most frekvent words: " + string.Join(',', text.MostFrequentWords));
            Console.WriteLine("Most common word: " + text.PrintArrayList(text.MostCommonWord()));
            Console.WriteLine("Smallest words: " + text.PrintArrayList(text.ShortestWord()));
            Console.WriteLine("Longest words: " + text.PrintArrayList(text.LongestWord()));
            Console.WriteLine("Alphabetic words order: " + text.PrintArrayList(text.SortedArray()));
        }
    }
}