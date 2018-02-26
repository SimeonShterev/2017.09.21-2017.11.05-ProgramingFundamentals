using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(.\d+)?($|(?=\s))";
            string input = Console.ReadLine();
            MatchCollection validNums = Regex.Matches(input, pattern);
            foreach(Match number in validNums)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
