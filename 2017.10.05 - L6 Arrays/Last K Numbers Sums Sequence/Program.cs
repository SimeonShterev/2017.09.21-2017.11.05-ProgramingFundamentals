using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] array = new long[n];
            array[0] = 1;
            for (long i = 0; i < array.Length; i++)
            {
                for (long j = i - k; j < i; j++)
                {
                    try
                    {
                        array[i] = array[i] + array[j];
                    }
                    catch(IndexOutOfRangeException)
                    { }            
                }
                Console.WriteLine(array[i]);
            }
        }
    }
}
