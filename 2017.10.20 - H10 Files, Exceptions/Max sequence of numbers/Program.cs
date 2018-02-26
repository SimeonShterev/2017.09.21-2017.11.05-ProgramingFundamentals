using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Max_sequence_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"..\..\Input.txt", "4 1 1 4 2 3 4 4 1 2 4 9 3");
            string sequence = File.ReadAllText(@"..\..\Input.txt");
            int[] arr = sequence.Split(' ').Select(int.Parse).ToArray();
            int number = 0;
            int count = 1;
            int bestCount = 0;
            int bestNum = 0;
            for(int i = 0;i<arr.Length;i++)
            {
                number = arr[i];
                for (int rep = i + 1; rep < arr.Length; rep++)
                {
                    if (number == arr[rep])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if(count>bestCount)
                    {
                        bestCount = count;
                        bestNum = arr[i];
                    }
                }
            }
            File.WriteAllText(@"..\..\Output.txt", "4");
            int result = int.Parse(File.ReadAllText(@"..\..\Output.txt"));
            if(result==bestNum)
            {
                Console.WriteLine("correct answer");
            }
            else
            {
                Console.WriteLine("wrong");
            }
        }
    }
}
