using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReversedNumbers(number);
        }
        static void ReversedNumbers(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--) 
            {
                Console.Write(num[i]);
            }
            Console.WriteLine();
        }
    }
}
