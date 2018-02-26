using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Convert_from_Base_N_to_Base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split();
            int nBase = int.Parse(data[0]);
            BigInteger number = BigInteger.Parse(data[1]);
            BigInteger base10Num = 0;
            int count = 0;
            BigInteger power = 1;
            while (number != 0)
            {
                BigInteger singleNum = (number % 10);
                singleNum = singleNum * power;
                power *= nBase;
                base10Num += singleNum;
                number /= 10;
                count++;
            }
            Console.WriteLine(base10Num);
        }
    }
}
