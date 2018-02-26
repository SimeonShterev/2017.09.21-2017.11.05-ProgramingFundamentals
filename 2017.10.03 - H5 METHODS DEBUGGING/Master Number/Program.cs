using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int i = 1; i<=number;i++)
            {
                if (IsSymetric(i) && ContainEvenNumber(i) && SumOfDigits(i))
                {
                    Console.WriteLine(i);
                } 
            }
        }
        static bool IsSymetric(int num)
        {
            bool statement = false;
            string number = num.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == number[number.Length - 1 - i])
                {
                    continue;
                }
                else
                {
                    return statement;
                }
            }
            return true;
        }
        static bool SumOfDigits(int num)
        {
            bool statement = false;
            int sum = 0;
            while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            if (sum % 7 == 0)
            {
                statement = true;
            }
            return statement;
        }
        static bool ContainEvenNumber(int num)
        {
            bool statement = false;
            string number = num.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '2' || number[i] == '4' || number[i] == '6' || number[i] == '8'|| number[i] == '0')
                {
                    statement = true;
                }
            }
            return statement;
        }
    }
}
