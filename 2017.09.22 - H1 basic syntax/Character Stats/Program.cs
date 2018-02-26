using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());

            while(true)
            {
                if (currentHealth > maxHealth)
                {
                    Console.WriteLine("current health>max health, enter new values");
                     currentHealth = int.Parse(Console.ReadLine());
                     maxHealth = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            while (true)
            {
                if (currentEnergy > maxEnergy)
                {
                    Console.WriteLine("current energy>max energy Enter new value");
                    currentEnergy = int.Parse(Console.ReadLine());
                    maxEnergy = int.Parse(Console.ReadLine());
                }
                else
                    break;
            }

            string health = "|" + new string('|', currentHealth) + new string('.', Math.Abs(maxHealth - currentHealth)) + "|";
            string energy = "|" + new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy) + "|";

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: {0}", health);
            Console.WriteLine("Energy: {0}", energy);
        }
    }
}
