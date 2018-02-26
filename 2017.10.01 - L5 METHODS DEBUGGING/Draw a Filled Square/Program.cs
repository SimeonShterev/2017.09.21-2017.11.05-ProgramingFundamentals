using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            PrintBorderLine(size);
            for (int i = 1; i <= size - 2; i++)
            {
                PrintFillingLine(size);
            }
            PrintBorderLine(size);
        }
        static void PrintBorderLine(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }
        static void PrintFillingLine(int number)
        {
            Console.Write("-");
            for (int i = 1; i <= number-1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}

