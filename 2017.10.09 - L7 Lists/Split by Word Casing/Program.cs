using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] paragraph = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '[', ']', '/', '\\', ' ' }
                , StringSplitOptions.RemoveEmptyEntries);
            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            List<string> mixed = new List<string>();
            int upperCase = 0;
            int lowerCase = 0;
            int mixedCase = 0;
            for (int i = 0; i < paragraph.Length; i++)
            {
                char[] word = paragraph[i].ToCharArray();
                for (int j = 0; j < paragraph[i].Length; j++)
                {
                    if (word[j] >= 65 && word[j] <= 90)
                    {
                        upperCase++;
                    }
                    if (word[j] >= 97 && word[j] <= 122)
                    {
                        lowerCase++;
                    }
                    if (word[j] < 65 || (word[j] > 90 && word[j] < 97) || word[j] > 122)
                    {
                        mixedCase++;
                    }
                }
                if (upperCase != 0 && lowerCase == 0 && mixedCase==0)
                {
                    upper.Add(paragraph[i]);
                }
                if (upperCase == 0 && lowerCase != 0 && mixedCase==0)
                {
                    lower.Add(paragraph[i]);
                }
                if (mixedCase!=0 || upperCase!=0 && lowerCase!=0)
                {
                    mixed.Add(paragraph[i]);
                }
                lowerCase = 0;
                upperCase = 0;
                mixedCase = 0;
            }
            Console.WriteLine("Lower-case: " + (string.Join(", ", lower)));
            Console.WriteLine("Mixed-case: " + (string.Join(", ", mixed)));
            Console.WriteLine("Upper-case: " + (string.Join(", ", upper)));
        }
    }
}
