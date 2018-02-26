using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = (hello + " " + world);
            string helloWorldd = (string)helloWorld;
            Console.WriteLine(helloWorldd);
        }
    }
}
