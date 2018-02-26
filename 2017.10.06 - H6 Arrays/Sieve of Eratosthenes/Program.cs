using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] numbers = new bool[n+1];
            for (int i =0 ; i <= n; i++)
            {
                numbers[i] = true;
            }
            for (int j = 2; j <=Math.Sqrt(n); j++)
            {
                if (numbers[j])
                {
                    for(int i=j*j; i<n+1;i +=j)
                    {
                        numbers[i] = false;
                    }
                }
            }
            for(int i =2; i <numbers.Length;i++)
            {
                if(numbers[i])
                    Console.Write(i + " ");
            }


        }
    }
}
