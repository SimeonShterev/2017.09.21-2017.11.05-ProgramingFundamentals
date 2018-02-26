using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            CheckPrimeNumber(number);
        }
        static void CheckPrimeNumber(long number)
        {
            long devider = 2;
            long primeChecker = 0;

            while(number % devider != 0 && devider <= Math.Sqrt(number))
            {
                devider++;
                if(number % devider == 0)
                {
                    primeChecker++;
                }
            }
            if(primeChecker!=0 || number==1 ||number==0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }

    }
}

