using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            int lapsLength = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());
            if (capacity * days < runners)
            {
                runners = capacity*days;
            }
            long totalDistanceRan = ((long)runners * laps *lapsLength) / 1000;
            double moneyDonated = totalDistanceRan * moneyPerKm;
            Console.WriteLine($"Money raised: {moneyDonated:f2}");
        }
    }
}
