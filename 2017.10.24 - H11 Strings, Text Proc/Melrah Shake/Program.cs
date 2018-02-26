using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string textCopy = string.Empty;
            string pattern = Console.ReadLine();
            while (true)
            {
                if (text.Contains(pattern))
                {
                    int firstIndex = text.IndexOf(pattern);
                    textCopy = text.Remove(firstIndex, pattern.Length);
                    if (textCopy.Contains(pattern))
                    {
                        int lastIndex = textCopy.LastIndexOf(pattern);
                        text = textCopy.Remove(lastIndex, pattern.Length);
                        Console.WriteLine("Shaked it.");
                    }
                    else
                    {
                        Console.WriteLine("No shake.");
                        Console.WriteLine(text);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    break; 
                }
                if (pattern.Length<=1)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    break;
                }
                int patternIndexToRemove = pattern.Length / 2;
                pattern = pattern.Remove(patternIndexToRemove, 1);
            }
        }
    }
}
