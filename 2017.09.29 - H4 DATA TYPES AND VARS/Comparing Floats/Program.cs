using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            if(Math.Abs(firstNum-secondNum)>0.000001)
            {
                Console.WriteLine("False");
            }
            else
                Console.WriteLine("True");
        }
    }
}
