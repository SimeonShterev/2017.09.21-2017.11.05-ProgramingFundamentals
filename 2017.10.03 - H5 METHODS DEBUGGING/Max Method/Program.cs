using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit1 = int.Parse(Console.ReadLine());
            int digit2 = int.Parse(Console.ReadLine());
            int digit3 = int.Parse(Console.ReadLine());
            if (digit1 > digit2)
            {
                GetMax(digit1, digit3);
            }
            else
                GetMax(digit3, digit2);
        }
        static void GetMax(int num1, int num2)
        {
            if (num1>num2)
                Console.WriteLine(num1);
            else
                Console.WriteLine(num2);
        }
    }
}
