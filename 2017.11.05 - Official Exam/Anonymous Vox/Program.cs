using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([a-zA-Z]+)(.+)\1";
            string input = Console.ReadLine();
            List<string> values = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.None).ToList();
            values.RemoveAll(x=>x=="");
            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> matchesList = new List<string>();
            foreach (Match match in matches)
            {
                matchesList.Add(match.Groups[2].Value);
            }
            for (int i = 0; i < matches.Count; i++)
            {
                int startIndex = input.IndexOf(matchesList[i]);
                string startOfInput = input.Substring(0, startIndex);
                string endOfInput = input.Substring(startIndex + matchesList[i].Length);
                input = startOfInput + values[i] + endOfInput;
            }
            Console.WriteLine(input);
        }
    }
}
