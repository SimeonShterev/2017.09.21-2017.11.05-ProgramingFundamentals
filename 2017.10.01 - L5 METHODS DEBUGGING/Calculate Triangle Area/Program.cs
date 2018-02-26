using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int heightt = int.Parse(Console.ReadLine());
            int basee = int.Parse(Console.ReadLine());
            double area = TriangleArea(heightt, basee);
            Console.WriteLine(area);
        }
        static double TriangleArea (int heigth,int basse)
        {
            return heigth * basse / 2.0;
        }
    }
}
