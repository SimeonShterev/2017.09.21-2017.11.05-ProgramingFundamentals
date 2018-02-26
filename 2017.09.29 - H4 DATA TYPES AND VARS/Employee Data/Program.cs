using System;
using System.Numerics;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalIDNumber = long.Parse(Console.ReadLine());
            BigInteger uniqueEmployeeNumber = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstname}");
            Console.WriteLine($"Last name: {lastname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalIDNumber}");
            Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");


        }
    }
}
