using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if(j<i)
                    {
                        leftSum += array[j];
                    }
                    if(j>i)
                    {
                        rightSum += array[j];
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }
        }
    }
}
