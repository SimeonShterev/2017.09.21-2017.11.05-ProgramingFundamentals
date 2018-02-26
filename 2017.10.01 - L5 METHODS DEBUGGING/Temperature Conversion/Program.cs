using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempInFahrenheit = double.Parse(Console.ReadLine());
            double tempInCelsius = FahrenheitToCelsius(tempInFahrenheit);
            Console.WriteLine($"{tempInCelsius:f2}");
        }
        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
