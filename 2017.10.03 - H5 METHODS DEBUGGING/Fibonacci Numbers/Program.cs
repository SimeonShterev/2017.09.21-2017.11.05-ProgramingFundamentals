using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int NthFibonacciNum = int.Parse(Console.ReadLine());
            GetFibonacciNumber(NthFibonacciNum);
        }
        static void GetFibonacciNumber(int position)
        {
            int lastFibonacciNum = 1;
            int currentFibonacciNum = 1;
            int nextFibonacciNum = 1;
            for (int i = 2; i <= position; i++)
            {
                nextFibonacciNum = currentFibonacciNum + lastFibonacciNum;
                lastFibonacciNum = currentFibonacciNum;
                currentFibonacciNum = nextFibonacciNum;
            }
            if(position==0 || position==1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(nextFibonacciNum);
            }
        }
    }
}
