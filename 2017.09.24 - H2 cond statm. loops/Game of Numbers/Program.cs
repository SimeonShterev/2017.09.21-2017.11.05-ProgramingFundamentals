using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int i=secondNum; i>=firstNum;i--)
            {
                for(int u = secondNum; u >= firstNum; u--)
                {
                    sum = i + u;
                    count++;
                    if (sum==magicNum)
                    {
                        firstNum = i;
                        secondNum = u;
                        break;
                    }
                }
                if (sum == magicNum)
                {
                    
                    break;
                }
            }
            if (sum==magicNum)
            {
                Console.WriteLine($"Number found! {firstNum} + {secondNum} = {magicNum}");

            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}
