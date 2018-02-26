using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            int lenght = Math.Min(firstArray.Length, secondArray.Length);
            for(int i=0; i<lenght;i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    if (firstArray[lenght-1]==secondArray[lenght-1] && i==lenght-1)
                    {
                        if(firstArray.Length<=secondArray.Length)
                        {
                            Console.WriteLine(firstArray);
                            Console.WriteLine(secondArray);
                        }
                        else
                        {
                            Console.WriteLine(secondArray);
                            Console.WriteLine(firstArray);
                        }
                    }
                    continue;
                }
                else if(firstArray[i]<secondArray[i])
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                    break;
                }
                else
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                    break;
                }
            }
            if (firstArray==secondArray)
            {
                Console.WriteLine("x");
            }
        }
    }
}
