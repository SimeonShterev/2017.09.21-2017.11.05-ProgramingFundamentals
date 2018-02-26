using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> sortNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            sortNumbers.Sort();
            Console.WriteLine(string.Join(" <= ", sortNumbers));
        }
    }
}
