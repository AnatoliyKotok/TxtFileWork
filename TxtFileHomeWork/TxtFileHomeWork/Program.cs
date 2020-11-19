using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtFileHomeWork
{
    

    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> wordsFromTxt = new List<string>();
            string fname = "Words.txt";
            string[] words = new string[] { "System", "using", "public", "void" };
            using (StreamWriter sw = new StreamWriter(fname, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i <words.Length; i++)
                {
                    sw.WriteLine(words[i]);
                }
            }
            string fname2 = "Program.txt";
            string[] words2 = new string[] { "System", "using", "public", "void", "void", "System", "public" };
            using (StreamWriter sw = new StreamWriter(fname2, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < words2.Length; i++)
                {
                    sw.WriteLine(words2[i]);
                }
            }
            using (StreamReader sr = new StreamReader(fname, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    wordsFromTxt.Add(line);
                }
            }
            List<string> wordsFromCs = new List<string>();
            using (StreamReader sr = new StreamReader(fname2, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    wordsFromCs.Add(line);
                }
            }
            SortedList<string, int> fundWords = new SortedList<string, int>();
            int count = 0;
            for (int  i = 0;  i <wordsFromTxt.Count;  i++)
            {
                for (int j = 0; j < wordsFromCs.Count; j++)
                {
                    if (wordsFromTxt[i] == wordsFromCs[j])
                    {
                        count++;
                    }
                }
                fundWords.Add(wordsFromTxt[i], count);
                count = 0;
            }
            foreach (var item in fundWords) 
            {
                Console.WriteLine($"{item.Key}-->{item.Value}");
            }
        }
    }
}
