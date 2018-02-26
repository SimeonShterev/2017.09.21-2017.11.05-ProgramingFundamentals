using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double bill;

            switch (profession)
            {
                case "Athlete":
                    bill = quantity * 0.7;
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession, bill);
                    break;
                case "SoftUni Student":
                    bill = quantity * 1.70;
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession, bill);
                    break;
                case "Businessman":
                case "Businesswoman":
                    bill = quantity * 1.0;
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession, bill);
                    break;
                default:
                    bill = quantity * 1.20;
                    Console.WriteLine("The {0} has to pay {1:f2}.", profession, bill);
                    break;
            }


        }
    }
}
