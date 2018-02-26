using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359 2 \d{3} \d{4}\b|\+359\-2-\d{3}\-\d{4}\b";
            string input = Console.ReadLine();
            MatchCollection matchedNumbers = Regex.Matches(input, pattern);
            string[] matchedNumArr = matchedNumbers.Cast<Match>().Select(x=>x.Value).ToArray();
            Console.WriteLine(string.Join(", ", matchedNumArr));
        }
    }
}
