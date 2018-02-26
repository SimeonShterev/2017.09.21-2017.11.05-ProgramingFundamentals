using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int totalTimeInSeconds = seconds + minutes * 60 + hours * 3600;
            float metersPerSecond = (float)meters / totalTimeInSeconds;
            float kilometersPerHour = ((float)meters / 1000) / ((float)totalTimeInSeconds / 3600);
            float milesPerHour = ((float)meters / 1609) / ((float)totalTimeInSeconds / 3600);
            Console.WriteLine($"{metersPerSecond:0.######}");
            Console.WriteLine($"{kilometersPerHour:0.######}");
            Console.WriteLine($"{milesPerHour:0.######}");
        }
    }
}
