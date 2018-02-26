using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');
            int[] arr1 = new int[array1.Length];
            int[] arr2 = new int[array2.Length];
            int moreIndexes = Math.Max(array1.Length, array2.Length);
            int[] sumArray = new int[moreIndexes];
            for(int i = 0; i<array1.Length; i++)
            {
                arr1[i] = int.Parse(array1[i]);
            }
            for (int j = 0; j < array2.Length; j++)
            {
                arr2[j] = int.Parse(array2[j]);
            }
            for (int k = 0; k < moreIndexes; k++)
            {
                sumArray[k] = arr1[k % array1.Length] + arr2[k % array2.Length];
                Console.Write(sumArray[k] + " ");
            }
        }
    }
}
