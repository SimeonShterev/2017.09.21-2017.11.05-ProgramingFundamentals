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
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number = 0;
            int lenght = 1;
            int bestNum = 0;
            int bestLenght = 0;
            for(int i=0;i<sequence.Count -1;i++)
            {
                number = sequence[i];
                if (sequence[i]==sequence[i+1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                }
                if(lenght>bestLenght)
                {
                    bestLenght = lenght;
                    bestNum = number;
                }
            }
            for(int i =1;i<=bestLenght;i++)
            {
                Console.Write("{0} ", bestNum);
            }
        }
    }
}
