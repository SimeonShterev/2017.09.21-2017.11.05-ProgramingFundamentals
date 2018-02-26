using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long resultSum = 0;
            while(input.Count!=0)
            {
                int index = int.Parse(Console.ReadLine());
                long numberToRemove = 0;
                if(index>=0 && index<=input.Count-1)
                {
                    numberToRemove = input[index];
                    input.RemoveAt(index);
                    ManilulateList(input, numberToRemove);
                    resultSum += numberToRemove;
                }
                else if(index<0)
                {
                    index = 0;
                    numberToRemove = input[index];
                    input.RemoveAt(index);
                    input.Insert(index, input[input.Count - 1]);
                    ManilulateList(input, numberToRemove);
                    resultSum += numberToRemove;
                }
                else if(index>=input.Count)
                {
                    index = input.Count - 1;
                    numberToRemove = input[index];
                    input.RemoveAt(index);
                    input.Insert(index, input[0]);
                    ManilulateList(input, numberToRemove);
                    resultSum += numberToRemove;
                }
            }
            Console.WriteLine(resultSum);
        }

        static void ManilulateList(List<long> input, long numberToRemove)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if(input[i]<=numberToRemove)
                {
                    input[i] += numberToRemove;
                }
                else
                {
                    input[i] -= numberToRemove;
                }
            }
        }
    }
}
