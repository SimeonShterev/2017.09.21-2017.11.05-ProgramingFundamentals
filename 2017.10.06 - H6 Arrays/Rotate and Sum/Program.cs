using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arrayInt = Array.ConvertAll(array, int.Parse);
            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];
            for (int i = 1; i <= rotations; i++)
            {
                int lastNumber = arrayInt[arrayInt.Length - 1];
                for (int j = array.Length - 1; j >0; j--)
                {
                    sum[j] = sum[j] + arrayInt[j - 1];
                    arrayInt[j] = arrayInt[j - 1];
                }
                arrayInt[0] = lastNumber;
                sum[0] += arrayInt[0];
            }
            Console.WriteLine($"{string.Join(" ", sum)}");
        }
    }
}
