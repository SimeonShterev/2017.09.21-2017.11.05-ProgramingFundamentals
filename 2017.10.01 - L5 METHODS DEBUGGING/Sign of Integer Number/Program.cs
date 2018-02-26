using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SignOfNumber(number);
        }
        static void SignOfNumber(int digit)
        {
            if (digit<0)
            {
                Console.WriteLine($"The number {digit} is negative.");
            }
            else if (digit>0)
            {
                Console.WriteLine($"the number {digit} is positive.");
            }
            else
            {
                Console.WriteLine($"the number {digit} is zero.");
            }
        }
    }
}
