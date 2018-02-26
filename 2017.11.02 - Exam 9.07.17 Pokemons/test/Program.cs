using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "final")
                    break;
                List<string> data = input.Split(' ').ToList();
                for (int i = 0; i < 2; i++)
                {
                    string[] test = data[i].Split(new string[] { pattern }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    Console.WriteLine(test.Length);
                }
                Console.WriteLine(string.Join("\n", data));
                Console.WriteLine();
            }
        }
    }
}
