using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] result = test.Skip(3).Take(3).ToArray();
            Console.WriteLine(string.Join(" ", result));
           //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           //List<int> evenNumbers = new List<int>();
           //List<int> oddNumbers = new List<int>();
           //for (int i = 0; i < numbers.Length; i++)
           //{
           //    if (numbers[i] % 2 == 0)
           //    {
           //        evenNumbers.Add(numbers[i]);
           //    }
           //    else
           //    {
           //        oddNumbers.Add(numbers[i]);
           //    }
           //}
           //double average = oddNumbers.Average();
           //for (int i = 0; i < evenNumbers.Count; i++)
           //{
           //    if (evenNumbers[i] > average)
           //        evenNumbers[i] += 1;
           //    else
           //        evenNumbers[i] -= 1;
           //}
           //Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }
}
