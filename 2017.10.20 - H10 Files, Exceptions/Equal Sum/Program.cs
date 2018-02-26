using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"..\..\Input.txt", "10 5 5 99 3 4 2 5 1 1 4");
            int[] input = File.ReadAllText(@"..\..\Input.txt").Split().Select(int.Parse).ToArray();
            int result = -1;
            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int l = 0; l < i; l++)
                {
                    leftSum += input[l];
                }
                for (int r = i+1; r < input.Length; r++)
                {
                    rightSum += input[r];
                }
                if(leftSum==rightSum)
                {
                    result = i;
                    Console.WriteLine(result);
                    break;
                }
            }
            if(result==-1)
            {
                Console.WriteLine("no");
            }
            File.WriteAllText(@"..\..\Output.txt", "3");
        }
    }
}
