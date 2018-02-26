using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_Endd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] array1 = new string[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                array1[i] = arr1[i];
            }
            string[] arr2 = Console.ReadLine().Split();
            string[] array2 = new string[arr2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                array2[i] = arr2[i];
            }
            int countLeft = 0;
            int countRight = 0;
            int shorterArray = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < shorterArray; i++)
            {
                if (array1[i] == array2[i])
                {
                    countLeft++;
                }
                else
                    break;
            }
            Array.Reverse(array1);
            Array.Reverse(array2);
            for (int i = 0; i < shorterArray; i++)
            {
                if (array1[i] == array2[i])
                {
                    countRight++;
                }
                else
                    break;
            }
            if(countLeft>=countRight)
            {
                Console.WriteLine(countLeft);
            }
            else
            {
                Console.WriteLine(countRight);
            }
        }
    }
}
