using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = ReadPoints(n);
            Point[] closestTwoPoints = FindClosestTwoPoints(points);
            int x1 = closestTwoPoints[0].x;
            int y1 = closestTwoPoints[0].y;
            int x2 = closestTwoPoints[1].x;
            int y2 = closestTwoPoints[1].y;
            PrintShortestDistance(x1, x2, y1, y2);
            Console.WriteLine($"({x1}, {y1})");
            Console.WriteLine($"({x2}, {y2})");
        }

        private static void PrintShortestDistance(int x1, int x2, int y1, int y2)
        {
            int sideA = Math.Abs(x1 - x2);
            int sideB = Math.Abs(y1 - y2);
            double sideToCalc = Math.Sqrt(sideA * sideA + sideB * sideB);
            Console.WriteLine($"{sideToCalc:f3}");
        }

        private static Point[] FindClosestTwoPoints(Point[] points)
        {
            double leastDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
                    int sideA = Math.Abs(points[i].x - points[j].x);
                    int sideB = Math.Abs(points[i].y - points[j].y);
                    double sideToCalc = Math.Sqrt(sideA * sideA + sideB * sideB);
                if(leastDistance>sideToCalc)
                    {
                        leastDistance = sideToCalc;
                        closestTwoPoints = new Point[] { points[i], points[j] };

                    }
                }
            }
            return closestTwoPoints;
        }

        private static Point[] ReadPoints(int n)
        {
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                int[] p1Info = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Point p = new Point();
                p.x = p1Info[0];
                p.y = p1Info[1];
                points[i] = p;
            }
                return points;
        }
    }
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
