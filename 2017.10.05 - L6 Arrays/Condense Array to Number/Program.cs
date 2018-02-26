using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            if (array.Length == 1)
            {
                Console.WriteLine("{0} is already condensed to number", array);
                return;
            }
            int[] arrayInt = new int[array.Length];
            int[] result = { 0 };
            for (int k = 0; k < arrayInt.Length; k++)
            {
                arrayInt[k] = int.Parse(array[k]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                int[] diffArr = new int[array.Length - i -1];
                for (int j = 0; j < (array.Length - i - 1); j++)
                {
                    diffArr[j] = arrayInt[j] + arrayInt[j + 1];
                    arrayInt[j] = diffArr[j];
                    result[0] = diffArr[j];
                }
            }
            Console.WriteLine(result[0]);
            
        }
    }
}
