using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceFor1000Flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            int time = wingFlaps / 100 + wingFlaps / endurance * 5;
            double distance = wingFlaps / 1000 *distanceFor1000Flaps;
            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine(time + " s.");
        }
    }
}
