using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = nums.Length / 4;
            int[] firstRow = nums.Take(k).Reverse().ToArray();
            int[] lastRow = nums.Reverse().Take(k).ToArray();
            int[] upperRow = firstRow.Concat(lastRow).ToArray();
            int[] lowerRow = nums.Skip(k).Take(2 * k).ToArray();
            for(int i =0; i<2*k;i++)
            {
                Console.Write(upperRow[i] + lowerRow[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
