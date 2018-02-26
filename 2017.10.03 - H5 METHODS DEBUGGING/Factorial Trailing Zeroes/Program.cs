using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            while(result%10==0)
            {
                count++;
                result = result / 10;
            }
            Console.WriteLine(count);
        }
    }
}
