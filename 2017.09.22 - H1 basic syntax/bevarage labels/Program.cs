﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevarage_labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100ml = int.Parse(Console.ReadLine());
            int sugarContentPer100ml = int.Parse(Console.ReadLine());
            double energyContent = energyContentPer100ml * volume / 100.0;
            double sugarContent = sugarContentPer100ml * volume / 100.0;

            Console.WriteLine("{0}ml {1}:" , volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars" , energyContent, sugarContent);
        }
    }
}
