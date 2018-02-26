using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            char[] firstWord = input[0].ToCharArray().Distinct().ToArray();
            char[] secondWord = input[1].ToCharArray().Distinct().ToArray();
            if(secondWord.Length==firstWord.Length)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");
        }
    }
}
