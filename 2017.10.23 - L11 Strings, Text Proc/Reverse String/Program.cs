using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            Console.WriteLine(ch);
        }
    }
}
