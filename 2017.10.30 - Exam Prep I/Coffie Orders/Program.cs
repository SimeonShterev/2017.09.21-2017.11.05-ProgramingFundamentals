using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffie_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0.0m;
            for (int i = 0; i < n; i++)
            {
                decimal price = CalculatePricePerOrder();
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }

        static decimal CalculatePricePerOrder()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string[] date = Console.ReadLine().Split('/');
            int month = int.Parse(date[1]);
            int year = int.Parse(date[2]);
            decimal daysInMonth = DateTime.DaysInMonth(year, month);
            int capsulesCount = int.Parse(Console.ReadLine());
            decimal price = daysInMonth * capsulesCount * pricePerCapsule;
            return price;
        }
    }
}

