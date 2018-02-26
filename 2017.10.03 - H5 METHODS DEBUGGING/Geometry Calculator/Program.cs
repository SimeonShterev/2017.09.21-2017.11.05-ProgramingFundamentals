using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if (figureType=="triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = GetTriangleArea(side, height);
                Console.WriteLine($"{area:f2}");
            }
            else if(figureType=="square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = GetSquareArea(side);
                Console.WriteLine($"{area:f2}");
            }
            else if(figureType=="circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = GetCircleArea(radius);
                Console.WriteLine($"{area:f2}");

            }
            else if(figureType=="rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = GetRectangleArea(width, height);
                Console.WriteLine($"{area:f2}");
            }

        }
        static double GetTriangleArea(double a, double h)
        {
            double area = a * h / 2;
            return area;
        }
        static double GetRectangleArea(double a, double b)
        {
            double area = a * b;
            return area;
        }
        static double GetCircleArea(double r)
        {
            double area = Math.PI * r * r;
            return area;
        }
        static double GetSquareArea(double a )
        {
            double area = a * a;
            return area;
        }
    }
}
