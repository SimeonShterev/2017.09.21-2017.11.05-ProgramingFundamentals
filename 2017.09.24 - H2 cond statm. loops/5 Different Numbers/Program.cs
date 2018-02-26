using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (secondNum - firstNum >= 5)
            {
                for (int i = firstNum; i<=secondNum; i ++)
                {
                    for (int j = firstNum; j <= secondNum; j++)
                    {
                        for (int k = firstNum; k <= secondNum; k++)
                        {
                            for (int g = firstNum; g <= secondNum; g++)
                            {
                                for (int d = firstNum; d <= secondNum; d++)
                                {
                                    if (i<j && j<k && k<g && g<d)
                                    {
                                        Console.WriteLine($"{i} {j} {k} {g} {d}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
