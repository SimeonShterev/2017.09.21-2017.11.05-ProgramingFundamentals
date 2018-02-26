using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string option = Console.ReadLine();
            if (option=="face")
            {
                GetDiagonals(side); 
            }
            else if (option=="space")
            {
                GetSpaceDiagonals(side); 
            }
            else if (option=="volume")
            {
               GetVolume(side);
            }
            else if (option=="area")
            {
                GetArea(side);
            }
        }
        static void GetVolume(double side)
        {
            double volume = side * side * side;
            Console.WriteLine($"{volume:f2}");
        }
        static void GetArea(double side)
        {
            double area = side * side * 6;
            Console.WriteLine($"{area:f2}");
        }
        static void GetDiagonals(double side)
        {
            double diagonal = Math.Sqrt(2 * side * side);
            Console.WriteLine($"{diagonal:f2}");
        }
        static void GetSpaceDiagonals(double side)
        {
            double spaceDiagonal = Math.Sqrt(3 * side * side);
            Console.WriteLine($"{spaceDiagonal:f2}");
        }
    }
}
