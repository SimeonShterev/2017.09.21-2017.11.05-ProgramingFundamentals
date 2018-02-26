using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Rage_Quit_Nakov
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            foreach (Match m in Regex.Matches(input, @"([^0-9]+)(\d+)"))
            {
                string word = m.Groups[1].Value.ToUpper();
                int count = int.Parse(m.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
            int uniqueSymbols = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(result.ToString());
        }
    }
}
