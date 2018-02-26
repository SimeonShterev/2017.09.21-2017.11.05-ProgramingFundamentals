using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ').ToArray();
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if(count.ContainsKey(item))
                {
                    count[item]++;
                }
                else
                {
                    count[item] = 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var item in count)
            {
                if (item.Value%2!=0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
