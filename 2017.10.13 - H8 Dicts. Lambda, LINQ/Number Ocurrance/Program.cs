using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionariesHashSets
{

    class Occurs
    {
        static void Print(SortedDictionary<int, int> dict)
        {
            foreach (var item in dict)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
                }
                else
                {
                    Console.WriteLine("{0} -> {1} time", item.Key, item.Value);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number of integers to input?:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
            foreach (int item in array)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item] += 1;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            Print(dict);
        }
    }
}