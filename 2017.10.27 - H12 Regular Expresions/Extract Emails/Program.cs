using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((^)|(?<= ))\w+(-|\.|_)?\w+@\w+-?\w+\.\w+(\.\w+)?(\.\w+)?(\.\w+)?\b";
            string text = Console.ReadLine();
            MatchCollection emails = Regex.Matches(text, pattern);
            foreach(Match email in emails)
            {
                string validEmail = email.ToString();
                if(!(validEmail.StartsWith(".") || validEmail.StartsWith("-") || validEmail.StartsWith("_") || validEmail.EndsWith(".") || validEmail.EndsWith("-") || validEmail.EndsWith("_")))
                {
                    Console.WriteLine($"{email}");
                }
            }
        }
    }
}
