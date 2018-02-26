using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string text = Console.ReadLine();
            string patternForKeyString = @"(?<startKey>[A-Za-z]+)(?:\\|\||<).+(?:\\|\||<)(?<endKey>[A-Za-z]+)";
            Match matchInKeyString = Regex.Match(keyString, patternForKeyString);
            string startKey = matchInKeyString.Groups["startKey"].Value;
            string endKey = matchInKeyString.Groups["endKey"].Value;
            string patternForText = $@"(?:{startKey})(.)(?:{endKey})";
            MatchCollection matchesInText = Regex.Matches(text, patternForText);
            StringBuilder sb = new StringBuilder();
            foreach (Match match in matchesInText)
            {
                sb.Append(match.Groups[1].Value);
            }
            string result = sb.ToString();
            if(result.Length!=0)
                Console.WriteLine(result);
            else
                Console.WriteLine("Empty result");
        }
    }
}
