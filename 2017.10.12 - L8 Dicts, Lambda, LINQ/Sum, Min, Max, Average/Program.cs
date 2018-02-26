using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = " + array.Sum());
            Console.WriteLine("Min = " + array.Min());
            Console.WriteLine("Max = " + array.Max());
            Console.WriteLine("Average = " + array.Average());
        }
    }
}
