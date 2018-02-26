using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder nonDigits = new StringBuilder();
            List<int> digits = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]>='0' && input[i]<='9')
                {
                    digits.Add(input[i] - 48);
                }
                else
                {
                    nonDigits.Append(input[i]);
                }
            }
            List<int> take = new List<int>();
            List<int> skip = new List<int>();
            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                    take.Add(digits[i]);
                else
                    skip.Add(digits[i]);
            }
            StringBuilder result = new StringBuilder();
            int skippedAndTakenChars = 0;
            for (int i = 0; i < take.Count; i++)
            {
                char[] strToAdd = nonDigits.ToString().Skip(skippedAndTakenChars).Take(take[i]).ToArray();
                skippedAndTakenChars += skip[i] + take[i];
                result.Append(new string(strToAdd));
            }
            Console.WriteLine(result);
        }
    }
}
