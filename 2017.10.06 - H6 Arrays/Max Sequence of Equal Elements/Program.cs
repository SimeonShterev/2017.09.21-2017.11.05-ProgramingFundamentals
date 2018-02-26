using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int lenght = 1;
            int sequence = 0;
            int bestLenght = 0;
            int bestSequence = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                sequence = numbers[i];
                if (sequence==numbers[i-1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                }
                if(bestLenght<lenght)
                {
                    bestLenght = lenght;
                    bestSequence = sequence;
                }
            }
            for (int i = 1; i <= bestLenght; i++)
            {
                Console.Write("{0} ",bestSequence);
            }
        }
    }
}
