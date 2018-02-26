using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(dec, 16);
            string binary = Convert.ToString(dec, 2);
            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(binary);
        }
    }
}
