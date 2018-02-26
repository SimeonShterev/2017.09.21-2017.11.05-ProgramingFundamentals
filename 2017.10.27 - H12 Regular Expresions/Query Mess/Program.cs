using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentances = Console.ReadLine();
            while (sentances != "END")
            {
                Dictionary<string, List<string>> keyValuePair = new Dictionary<string, List<string>>();
                string switcWitWhiteSpace = @"((%20|\+)+)";
                sentances = Regex.Replace(sentances, switcWitWhiteSpace, " ");
                string pattern = @"(?:^|(?<=\?)|(?<=&))(.+?)=(.+?)(?:&|$)";
                MatchCollection keyValues = Regex.Matches(sentances, pattern);
                foreach(Match keyValue in keyValues)
                {
                    string key = keyValue.Groups[1].Value.Trim();
                    if(key.Contains('?'))
                    {
                        key = key.Substring(key.IndexOf('?') + 1);
                    }
                    string value = keyValue.Groups[2].Value.Trim();
                    if (keyValuePair.ContainsKey(key))
                    {
                        keyValuePair[key].Add(value);
                    }
                    else
                    {
                        keyValuePair.Add(key, new List<string>());
                        keyValuePair[key].Add(value);
                    }
                }
                foreach (var keyvalue in keyValuePair)
                {
                    Console.Write($"{keyvalue.Key}=[{string.Join(", ", keyvalue.Value)}]");
                }
                Console.WriteLine();
                sentances = Console.ReadLine();
            }
            

        }
    }
}
