using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayStr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] arraylong = new long[arrayStr.Length];
            long count = 0;
            for (long j = 0; j <= arraylong.Length - 1; j++)
            {
                arraylong[j] = long.Parse(arrayStr[j]);
            }
            for (long index = 0; index <= arraylong.Length - 2; index++)
            {
                for (long i = index + 1; i <= arraylong.Length - 1; i++)
                {
                    for (long k = 0; k < arraylong.Length; k++)
                    {
                        if (arraylong[k] == arraylong[index] + arraylong[i])
                        {
                            Console.WriteLine($"{arraylong[index]} + {arraylong[i]} == {arraylong[k]}");
                            count++;
                        }
                    }
                }
            }
            if(count==0)
                Console.WriteLine("No");
        }
    }
}
