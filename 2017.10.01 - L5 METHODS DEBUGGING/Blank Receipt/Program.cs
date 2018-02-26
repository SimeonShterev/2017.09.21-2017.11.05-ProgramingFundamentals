using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIP");
            Console.WriteLine("---------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to:________________");
            Console.WriteLine("Recieved by:_______________");
        }
        static void PrintFooter()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("@ SoftUni");
        }
    }
}
