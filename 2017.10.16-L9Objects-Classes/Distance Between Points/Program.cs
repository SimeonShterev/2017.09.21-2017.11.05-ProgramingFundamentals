using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var XY1 = new Point();
            var XY2 = new Point();
            double sideToCalc = CalcSide(XY1, XY2);
            Console.WriteLine($"{sideToCalc:f2}");
        }

        private static double CalcSide(Point XY1, Point XY2)
        {
            int[] XY1Coord = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] XY2Coord = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            XY1.X = XY1Coord[0];
            XY1.Y = XY1Coord[1];
            XY2.X = XY2Coord[0];
            XY2.Y = XY2Coord[1];
            int sideA = Math.Abs(XY1.X - XY2.X);
            int sideB = Math.Abs(XY1.Y - XY2.Y);
            double sideToCalc = Math.Sqrt(sideA * sideA + sideB * sideB);
            return sideToCalc;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
