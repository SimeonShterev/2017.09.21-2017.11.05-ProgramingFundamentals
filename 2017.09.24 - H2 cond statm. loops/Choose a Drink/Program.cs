﻿using System;
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
            switch(profession)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
               

        }
    }
}
