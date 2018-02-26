using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startSymbol = int.Parse(Console.ReadLine());
            int endSymbol = int.Parse(Console.ReadLine());
            for (char i = (char)startSymbol; i <= endSymbol; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
