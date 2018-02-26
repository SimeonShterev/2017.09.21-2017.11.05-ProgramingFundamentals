using System;
using System.Numerics;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = hours * 3600L;
            BigInteger milliseconds = (BigInteger)hours * 3600 * 1000;
            BigInteger microseconds = (BigInteger)hours * 3600 * 1000000;
            BigInteger nanoseconds = (BigInteger)hours * 3600 * 1000000000;
            Console.WriteLine(@"{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}
