using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int[] arr = new int[array.Length];
            int middle = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                arr[i] = int.Parse(array[i]);
            }
            if (array.Length == 1)
            {
                Console.WriteLine("{ " + array[0] + " }");
            }
            else if (array.Length % 2 == 0)
            {
                middle = array.Length / 2;
                Console.WriteLine("{ " + arr[middle - 1] + ", " + arr[middle] + " }");
            }
            else if (array.Length % 2 == 1)
            {
                middle = array.Length / 2;
                Console.WriteLine("{ " + arr[middle - 1] + ", " + arr[middle] + ", " + arr[middle + 1] + " }");
            }
        }
    }
}
