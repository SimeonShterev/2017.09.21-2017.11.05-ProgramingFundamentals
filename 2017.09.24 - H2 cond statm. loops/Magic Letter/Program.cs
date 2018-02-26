using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());
            char exceptionLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= lastLetter; i++)
            {
                for (char j = firstLetter; j <= lastLetter; j++)
                {
                    for (char k = firstLetter; k <= lastLetter; k++)
                    {
                        if (i != exceptionLetter && j != exceptionLetter && k != exceptionLetter)
                            Console.Write("{0}{1}{2} ", i, j, k);
                    }
                }
            }
        }
    }
}
