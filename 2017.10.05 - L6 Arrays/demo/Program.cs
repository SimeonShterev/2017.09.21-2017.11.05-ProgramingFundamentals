using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] SomeCollection = { 1, 2, 7, 4, 5, 6, 55, 8, 9, 10, 11 };
            var results = from c in SomeCollection
                          where c < 10
                          select c;
                          

            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
