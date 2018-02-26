using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();
            MatchCollection hex = Regex.Matches(input, pattern);
            string[] hexArr = hex.Cast<Match>().Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(" ", hexArr));
        }
    }
}
