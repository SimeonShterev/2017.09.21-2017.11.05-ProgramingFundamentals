using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            string[] reverseaArray = new string[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverseaArray[i] = array[i];
                Console.Write(reverseaArray[i] + " ");
            }
        }
    }
}
