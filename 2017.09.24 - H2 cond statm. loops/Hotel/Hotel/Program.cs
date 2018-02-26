using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double StudioPrice = 0.0;
            double DoublePrice = 0.0;
            double SuitPrice = 0.0;
            double totalStudioPrice = 0.0;
            double totalDoublePrice = 0.0;
            double totalSuitPrice = 0.0;

            if (month=="May" || month=="October")
            {
                StudioPrice = 50;
                DoublePrice = 65;
                SuitPrice = 75;
            }
            else if (month=="June" || month=="September")
            {
                StudioPrice = 60;
                DoublePrice = 72;
                SuitPrice = 82;
            }
            else if (month=="July" || month=="August" || month=="December")
            {
                StudioPrice = 68;
                DoublePrice = 77;
                SuitPrice = 89;
            }

            if (nightsCount > 7 && (month == "October" || month == "May"))
            {
                StudioPrice *= 0.95;
            }
            else if (nightsCount > 14 && (month == "June" || month == "September"))
            {
                DoublePrice *= 0.9;
            }
            else if (nightsCount > 14 && (month == "July" || month == "August" || month == "December"))
            {
                SuitPrice *= 0.85;
            }
            
            totalStudioPrice = (double)StudioPrice * nightsCount;
            totalDoublePrice = (double)DoublePrice * nightsCount;
            totalSuitPrice = (double)SuitPrice * nightsCount;

            if (nightsCount > 7 && (month == "October" || month == "September"))
            {
                totalStudioPrice = (double)StudioPrice * (nightsCount - 1);
            }

            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
            Console.WriteLine("Suite: {0:f2} lv.", totalSuitPrice);
        }
    }
}
