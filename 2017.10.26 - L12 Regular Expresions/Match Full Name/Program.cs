using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string text = Console.ReadLine();
            MatchCollection names = Regex.Matches(text, pattern);
            foreach(Match name in names)
            {
                Console.Write(name + " ");
            }
        }
    }
}
