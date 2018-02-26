using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Sentances_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToExtract = Console.ReadLine();
            string pattern = $"\\b{wordToExtract}\\b";
            string text = Console.ReadLine();
            string[] sentances = text.Split(new char[] {'.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(var sentance in sentances)
            {
                Regex regex = new Regex(pattern);
                if(regex.IsMatch(sentance))
                {
                    Console.WriteLine(sentance.Trim());
                }
            }
        }
    }
}
