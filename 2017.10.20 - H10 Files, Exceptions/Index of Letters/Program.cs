using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"..\..\Input.txt", "abcz");
            string str = File.ReadAllText(@"..\..\Input.txt");
            string result = string.Empty;
            foreach (char letter in str)
            {
                int letterNum = letter - 97;
                Console.WriteLine($"{letter} -> {letterNum}");
                result = $"{letter} -> {letterNum} \r\n";
                File.AppendAllText(@"..\..\Output.txt", result);
            }
        }
    }
}
