using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int last = 0;
            for (int i = 1; i <= n; i++)
            {
                last = Fib(i);
            }
            Console.WriteLine(last);
        }

        private static int Fib(int i)
        {
            if(i<=2)
            {
                return i;
            }
            else
            {
                return Fib(i - 1) + Fib(i - 2);
            }

        }
    }
}
