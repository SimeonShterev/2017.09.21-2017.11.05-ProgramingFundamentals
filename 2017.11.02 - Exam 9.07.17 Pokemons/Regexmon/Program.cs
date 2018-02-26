using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string didimonPattern = $"[^a-zA-Z-]+";
            string bojomonPattern = $"[a-zA-Z]+-[a-zA-Z]+";
            string text = Console.ReadLine();
            while (true)
            {
                Match didiMatch = Regex.Match(text, didimonPattern);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch);
                    int index = text.IndexOf(didiMatch.ToString());
                    text = text.Substring(index + didiMatch.ToString().Length);
                }
                else
                {
                    break;
                }
                Match bojoMatch = Regex.Match(text, bojomonPattern);
                if(bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch);
                    int index = text.IndexOf(bojoMatch.ToString());
                    text = text.Substring(index + bojoMatch.ToString().Length);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
