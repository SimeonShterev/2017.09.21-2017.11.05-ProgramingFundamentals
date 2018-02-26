using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());
            int count = 0;
            int Sum = 0;

            for (int i = firstNum; i >= 1; i--)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    count++;
                    Sum = Sum + 3 * i * j;
                    if (Sum>=maxNum)
                    {
                        break;
                    }
                }
                if (Sum >= maxNum)
                {
                    break;
                }
            }
            Console.WriteLine($"{count} combinations");
            if (Sum>=maxNum)
            {
                Console.WriteLine("Sum: {0} >= {1}", Sum, maxNum);
            }
            else
            {
                Console.WriteLine("Sum: {0}", Sum);
            }
        }
    }
}
