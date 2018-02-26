using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int currentNum = 0;
            int count = 1;
            int bestCount = 0;
            int bestNum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                currentNum = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    if(currentNum==array[j])
                    {
                        count++;
                    }
                    if(bestCount<count)
                    {
                        bestCount = count;
                        bestNum = currentNum;
                    }
                }
                count = 1;
            }
            Console.WriteLine(bestNum);
        }
    }
}
