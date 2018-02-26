using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(\d{2})([-.\/])([A-Z][a-z]{2})\2(\d{4})\b";
            string input = Console.ReadLine();
            MatchCollection validDates = Regex.Matches(input, pattern);
            foreach(Match date in validDates)
            {
                string day = date.Groups[1].Value;
                string month = date.Groups[3].Value;
                string year = date.Groups[4].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
