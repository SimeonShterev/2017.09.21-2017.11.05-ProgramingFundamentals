using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehivesList = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornetsList = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            for (int i = 0; i < beehivesList.Count; i++)
            {
                long hornetsPower = hornetsList.Sum();
                if(beehivesList[i]>hornetsPower)
                {
                    beehivesList[i] -= hornetsPower;
                    hornetsList.RemoveAt(0);
                }
                else if(beehivesList[i]<hornetsPower)
                {
                    beehivesList.RemoveAt(i);
                    i -= 1;
                }
                else if(beehivesList[i]==hornetsPower)
                {
                    beehivesList.RemoveAt(i);
                    hornetsList.RemoveAt(0);
                    i -= 1;
                }
                if(hornetsList.Count==0)
                {
                    break;
                }
            }
            if(beehivesList.Count!=0)
            {
                Console.WriteLine(string.Join(" ", beehivesList));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornetsList));
            }
        }
    }
}
