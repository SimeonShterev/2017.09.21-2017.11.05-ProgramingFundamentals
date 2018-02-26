using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double[] num = new double[array.Length];
            int[] roundedNum = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                num[i] = double.Parse(array[i]);
                roundedNum[i] = (int)Math.Round(num[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num[i]} => {roundedNum[i]}");
            }
        }
    }
}
