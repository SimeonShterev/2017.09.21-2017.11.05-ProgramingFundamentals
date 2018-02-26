using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int int1 = int.Parse(Console.ReadLine());
                int int2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(int1, int2));
            }
            else if (type == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(char1, char2));
            }
            else if (type == "string")
            {
                string string1 = Console.ReadLine();
                string string2 = Console.ReadLine();
                Console.WriteLine(GetMax(string1, string2));
            }
        }
        static int GetMax(int value1, int value2)
        {
            int result = 0;
            if (value1 >= value2)
            {
                result = value1;
            }
            else
            {
                result = value2;
            }
            return result;
        }

        static char GetMax(char value1, char value2)
        {
            char result = '\u0000';
            if (value1 >= value2)
            {
                result = value1;
            }
            else
            {
                result = value2;
            }
            return result;
        }

        static string GetMax(string value1, string value2)
        {
            string result = string.Empty;
            if (value1.CompareTo(value2) >= 0)
            {
                result = value1;
            }
            else
            {
                result = value2;
            }
            return result;
        }

    }
}
