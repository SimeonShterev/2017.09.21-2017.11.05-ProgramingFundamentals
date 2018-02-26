using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallName = string.Empty;
            int discount = 0;
            double priceForThehall = 0.0;
            double discountPrice = 0.0;
            double pricePerPerson = 0.0;

            if (numOfPeople>0 && numOfPeople<=50)
            {
                priceForThehall = 2500;
                hallName = "Small Hall";
            }
            else if (numOfPeople>50 && numOfPeople<=100)
            {
                priceForThehall = 5000;
                hallName = "Terrace";
            }
            else if (numOfPeople>100 && numOfPeople<=120)
            {
                priceForThehall = 7500;
                hallName = "Great Hall";
            }
            else
                Console.WriteLine("We do not have an appropriate hall.");

            switch (package)
            {
                case "Normal":
                    discount = 5;
                    discountPrice = 500;
                    break;
                case "Gold":
                    discount = 10;
                    discountPrice = 750;
                    break;
                case "Platinum":
                    discount = 15;
                    discountPrice = 1000;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            pricePerPerson = (priceForThehall + discountPrice)*(100-discount)/100/numOfPeople;

            if (hallName!=string.Empty)
            {
                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
            }
            

        }
    }
}
