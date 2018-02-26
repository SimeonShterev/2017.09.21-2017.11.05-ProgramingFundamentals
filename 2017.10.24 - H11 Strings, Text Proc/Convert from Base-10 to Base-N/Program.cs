using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split();
            int nBase = int.Parse(data[0]);
            BigInteger number = BigInteger.Parse(data[1]);
            string nBaseNum = string.Empty;
            while(number!=0)
            {
                int singleNum = (int)(number % nBase);
                number /= nBase;
                nBaseNum = nBaseNum + singleNum;
            }
            char[] nBaseNumChar = nBaseNum.ToCharArray();
            Array.Reverse(nBaseNumChar);
            Console.WriteLine(nBaseNumChar);
        }
    }
}
