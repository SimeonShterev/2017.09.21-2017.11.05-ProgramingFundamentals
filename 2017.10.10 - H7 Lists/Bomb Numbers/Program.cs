using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersToDetonate = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = numbersToDetonate.IndexOf(bombNumber[0]);
            for(int i = 0; i<numbersToDetonate.Count-1;i++)
            {
                if(numbersToDetonate[i]==bombNumber[0])
                {
                    for(int j=i-bombNumber[1];j<=i+bombNumber[1];j++)
                    {
                        if(j>=0 && j<numbersToDetonate.Count)
                        {
                            numbersToDetonate[j] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(numbersToDetonate.Sum());
        }
    }
}
