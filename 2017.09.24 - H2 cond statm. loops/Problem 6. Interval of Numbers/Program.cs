using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int copyValue = 0;
                                      
            if (firstNum>endNum)
            {
                copyValue = firstNum;
                firstNum = endNum;
                endNum = copyValue;
            }
            for (int i = firstNum; i <= endNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
