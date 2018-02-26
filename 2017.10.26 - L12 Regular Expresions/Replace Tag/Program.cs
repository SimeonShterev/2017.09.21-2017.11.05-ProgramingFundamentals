using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Replace_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a href=""(.+)"">(.+)<\/a>";
            string input = Console.ReadLine();
            while (input != "end")
            {
                string output = string.Empty;
                Match ismatch = Regex.Match(input, pattern);
                if (Regex.IsMatch(input, pattern))
                {
                    string replacement = $@"[URL href=""{ismatch.Groups[1]}""]{ismatch.Groups[2]}[/URL]";
                    output = Regex.Replace(input, pattern, replacement);
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
