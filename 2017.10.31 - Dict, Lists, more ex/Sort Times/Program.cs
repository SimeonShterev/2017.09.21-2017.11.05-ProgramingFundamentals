﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> time = new List<string>(Console.ReadLine().Split(' ').ToList());
            time.Sort();
            Console.WriteLine(string.Join(", ", time));
        }
    }
}
