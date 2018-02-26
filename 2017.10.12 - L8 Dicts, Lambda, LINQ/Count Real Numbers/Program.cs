using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> count = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if(count.ContainsKey(number))
                {
                    count[number]++;
                }
                else
                {
                    count[number] = 1;
                }
            }
            foreach (var item in count)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
