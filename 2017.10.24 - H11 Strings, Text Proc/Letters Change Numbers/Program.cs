using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { " ", "\t", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal sum = 0.0m;
            for (int i = 0; i < input.Length; i++)
            {
                int devider = 0;
                int multiplier = 0;
                int adder = 0;
                int subtracktor = 0;
                decimal sumPart = 0.0m;
                char[] piece = input[i].ToCharArray();
                int[] digits = input[i].Skip(1).Take(input[i].Length - 2).Select(x => x - 48).ToArray();
                StringBuilder numsb = new StringBuilder();
                foreach (var digit in digits)
                {
                    numsb.Append(digit);
                }
                int number = int.Parse(numsb.ToString());
                if (piece[0] >= 'A' && piece[0] <= 'Z')
                {
                    devider = piece[0] - 64;
                    sumPart = (decimal)number / devider;
                }
                if (piece[0] >= 'a' && piece[0] <= 'z')
                {
                    multiplier = piece[0] - 96;
                    sumPart = (decimal)number * multiplier;
                }
                if (piece[input[i].Length - 1] >= 'A' && piece[input[i].Length - 1] <= 'Z')
                {
                    subtracktor = piece[input[i].Length - 1] - 64;
                    sumPart -= subtracktor;
                }
                if(piece[input[i].Length - 1] >= 'a' && piece[input[i].Length - 1] <= 'z')
                {
                    adder = piece[input[i].Length - 1] - 96;
                    sumPart += adder;
                }

                sum += sumPart;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
