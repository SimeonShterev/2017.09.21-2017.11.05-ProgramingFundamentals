using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            int count = input.Count;
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                var randomWord = rnd.Next(input.Count);
                Console.WriteLine(input[randomWord]);
                input.RemoveAt(randomWord);
            }
        }
    }
}
