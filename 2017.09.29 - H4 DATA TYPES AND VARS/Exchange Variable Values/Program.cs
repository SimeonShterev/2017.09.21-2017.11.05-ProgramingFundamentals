using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            byte c = a;
            a = b;
            b = c;

            Console.WriteLine($"Before:\r\na = {b}\r\nb = {a}");
            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");

        }
    }
}
