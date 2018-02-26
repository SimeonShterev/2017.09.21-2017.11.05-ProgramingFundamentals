using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            for(int i=0; i<number;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for(int j=array.Length-1; j>=0;j--)
            {
                Console.Write(array[j] + " ");
            }
        }
    }
}
