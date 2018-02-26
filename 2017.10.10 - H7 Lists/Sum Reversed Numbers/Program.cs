using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] numbers = Console.ReadLine().ToCharArray();
            Array.Reverse(numbers);
            string nums = new string(numbers);
            int[] reversedNums = nums.Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            for(int i = 0; i<reversedNums.Length; i++)
            {
                int singleNum = reversedNums[i];
                sum += singleNum;
            }
            Console.WriteLine(sum);
        }
    }
}
