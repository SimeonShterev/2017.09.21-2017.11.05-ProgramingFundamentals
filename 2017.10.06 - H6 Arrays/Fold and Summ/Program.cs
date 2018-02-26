using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Summ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] leftArr = numbers.Take(k).ToArray();
            int[] middleArr = numbers.Skip(k).Take(2 * k).ToArray();
            int[] rightArr = numbers.Skip(3 * k).Take(k).ToArray();
            Array.Reverse(leftArr);
            Array.Reverse(rightArr);
            int[] leftSum = new int[k];
            int[] rightSum = new int[k];
            for (int i = 0; i < k ; i++)
            {
                leftSum[i] = middleArr[i] + leftArr[i];
                rightSum[i] = middleArr[k + i] + rightArr[i];
            }
            Console.Write(string.Join(" ", leftSum) + " " + string.Join(" ", rightSum));
        }
    }
}
