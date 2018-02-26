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
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                PrintLine(1, i);
            }
            for (int j = n; j >= 1; j--)
            {
                PrintLine(1, j);
            }
        }
        static void PrintLine(int startNum, int endNum)
        {
            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

