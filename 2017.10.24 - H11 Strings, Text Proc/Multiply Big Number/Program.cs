using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            char[] secondNum = Console.ReadLine().ToCharArray();
            StringBuilder sb = new StringBuilder();
            int reminder = 0;
            int sum = 0;
            for (int i = firstNum.Length - 1; i >=0; i--)
            {
                sum = (firstNum[i] - 48) * (secondNum[0] - 48) + reminder;
                sb.Append(sum % 10);
                reminder = sum / 10;
                if (reminder != 0 && i == 0)
                {
                    sb.Append(reminder);
                }
            }
            char[] resultch = sb.ToString().TrimEnd('0').ToCharArray();
            Array.Reverse(resultch);
            string result = new string(resultch);
            if (result.Length == 0)
                Console.WriteLine("0");
            else
            Console.WriteLine(result);
        }
    }
}
