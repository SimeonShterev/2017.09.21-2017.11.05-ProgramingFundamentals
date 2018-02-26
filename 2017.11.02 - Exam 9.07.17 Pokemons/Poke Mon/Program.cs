using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerOrg = int.Parse(Console.ReadLine());
            int power = powerOrg;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int count = 0;
            while(power>=distance)
            {
                count++;
                power -= distance;
                if(power*2==powerOrg && exhaustionFactor!=0)
                {
                    power /= exhaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}
