using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = $"(.+?)([0-9]+)";
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                string word = match.Groups[1].Value;
                int times = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < times; i++)
                {
                    result.Append(word);
                }
            }
            string resultString = string.Join("", result.ToString().Distinct());
            int uniqueEl = resultString.Count();
            Console.WriteLine($"Unique symbols used: {uniqueEl}");
            Console.WriteLine(result);
        }
    }
}
