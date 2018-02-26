using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            CloserPodouble(x1, y1, x2, y2);
        }
        static void CloserPodouble(double x1, double y1, double x2, double y2)
        {
            double diagonal1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double diagonal2 = Math.Sqrt(x2 * x2 + y2 * y2);
            double shorterDiagonal = Math.Min(diagonal1, diagonal2);
            if (diagonal1==shorterDiagonal)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
                Console.WriteLine($"({x2}, {y2})");

        }
    }
}
