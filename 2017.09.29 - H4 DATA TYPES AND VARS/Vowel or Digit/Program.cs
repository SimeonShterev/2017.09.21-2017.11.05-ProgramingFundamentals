using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            if (symbol>'\u002f' && symbol<'\u003a')
            {
                Console.WriteLine("digit");
            }
            else if (symbol=='a' || symbol == 'e' || symbol == 'o' || symbol == 'i' || symbol == 'u' || symbol == 'y')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
