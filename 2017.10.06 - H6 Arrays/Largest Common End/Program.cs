using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondtArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int lenght = Math.Min(firstArr.Length, secondtArr.Length);
            int count = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (firstArr[i]==secondtArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            Array.Reverse(firstArr);
            secondtArr = secondtArr.Reverse().ToArray();
            int rightCount = Find
        }
        static int Find(string[] firstArray, string[] SecondArray)
        {
            for (int i = 0; i < lenght; i++)
            {
                if (firstArr[i] == secondtArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
