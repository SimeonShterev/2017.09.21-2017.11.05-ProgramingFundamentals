using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            char[] firstWord = input[0].ToCharArray();
            char[] secondWord = input[1].ToCharArray();
            int smallerLength = Math.Min(firstWord.Length, secondWord.Length);
            int biggerLength = Math.Max(firstWord.Length, secondWord.Length);
            int sum = 0;
            for (int i = 0; i < smallerLength; i++)
            {
                sum = sum + firstWord[i] * secondWord[i];
            }
            for (int i =smallerLength; i < biggerLength; i++)
            {
                if (firstWord.Length > secondWord.Length)
                {
                    sum = sum + firstWord[i];
                }
                else
                {
                    sum += secondWord[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
