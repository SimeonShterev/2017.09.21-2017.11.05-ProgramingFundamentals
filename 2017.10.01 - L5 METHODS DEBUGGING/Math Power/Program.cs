using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            int result = GetMathPower(num, pow);
            Console.WriteLine(result);
        }
        static int GetMathPower(int number, int power)
        {
            int result = 1;
            for (int i =1;i<=power;i++)
            {
                result = number * result;
            }
            return result;
        }
    }
}
