using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damegeGosho = int.Parse(Console.ReadLine());
            int healthPesho = 100;
            int healthGosho = 100;
            int round = 0;

            while(healthGosho>0 && healthPesho>0)
            {
                round++;
                if (round % 2 == 0)
                {
                    healthPesho -= damegeGosho;
                    if (healthPesho <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", round);
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                }
                else
                {
                    healthGosho -= damagePesho;
                    if (healthGosho <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", round);
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");

                }
                if (round % 3 == 0)
                {
                    healthGosho += 10;
                    healthPesho += 10;
                }
            }
            
        }
    }
}
