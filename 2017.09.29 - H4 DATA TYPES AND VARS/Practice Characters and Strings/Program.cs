﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Characters_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase1 = Console.ReadLine();
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());
            string phrase2 = Console.ReadLine();

            Console.WriteLine(phrase1);
            Console.WriteLine(letter1);
            Console.WriteLine(letter2);
            Console.WriteLine(letter3);
            Console.WriteLine(phrase2);
        }
    }
}
