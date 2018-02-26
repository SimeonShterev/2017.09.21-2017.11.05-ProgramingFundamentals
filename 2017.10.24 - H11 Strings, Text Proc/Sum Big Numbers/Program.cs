using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            if (firstNum.Length > secondNum.Length)
            {
                secondNum = secondNum.PadLeft(firstNum.Length, '0');
            }
            else
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }
            char[] firstNumChar = firstNum.ToCharArray();
            char[] secondNumChar = secondNum.ToCharArray();
            Array.Reverse(firstNumChar);
            Array.Reverse(secondNumChar);
            firstNum = new string(firstNumChar);
            secondNum = new string(secondNumChar);
            StringBuilder sb = new StringBuilder();
            int reminder = 0;
            int sum = 0;
            for (int i = 0; i < firstNum.Length; i++)
            {
                sum = firstNum[i] - 48 + secondNum[i] - 48 + reminder;
                sb.Append(sum % 10);
                reminder = sum / 10;
                if (reminder != 0 && i == firstNum.Length - 1)
                {
                    sb.Append(reminder);
                }
            }
            char[] resultch = sb.ToString().TrimEnd('0').ToCharArray();
            Array.Reverse(resultch);
            string result = new string(resultch);
            Console.WriteLine(result);
        }
    }
}
