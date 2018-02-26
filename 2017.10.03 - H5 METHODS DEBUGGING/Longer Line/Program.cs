using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double lineA = GetLenght(x1, y1, x2, y2);
            double lineB = GetLenght(x3, y3, x4, y4);
            if (lineA > lineB)
            {
                PrintLongerLine(x1, y1, x2, y2);
            }
            else
            {
                PrintLongerLine(x3, y3, x4, y4);
            }

        }
        static double GetLenght(double x1, double y1, double x2, double y2)
        {
            double sideA = Math.Abs(x1 - x2);
            double sideB = Math.Abs(y1 - y2);
            double lineA = Math.Sqrt(sideA * sideA + sideB * sideB);
            return lineA;
        }
        static void PrintLongerLine(double x1, double y1, double x2, double y2)
        {
            double distanceToCenter1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double distanceToCenter2 = Math.Sqrt(x2 * x2 + y2 * y2);
            double shorterDiagonal = Math.Min(distanceToCenter1, distanceToCenter2);
            if (distanceToCenter1 == shorterDiagonal)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }
    }
}



