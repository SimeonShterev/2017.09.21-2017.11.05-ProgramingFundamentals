using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                List<string> cmd = Console.ReadLine().Split(' ').ToList();
                if (cmd[0] == "end")
                    break;
                switch (cmd[0])
                {
                    case "exchange":
                        SwitchByIndex(numbers, cmd);
                        break;
                    case "max":
                        PrintIndexOfMaxEvenOddNumber(numbers, cmd);
                        break;
                    case "min":
                        PrintIndexOfMinEvenOddNumber(numbers, cmd);
                        break;
                    case "first":
                        PrintFirstCountEvenOddNumbers(numbers, cmd);
                        break;
                    case "last":
                        PrintLastCountEvenOddNumbers(numbers, cmd);
                        break;
                }
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static void PrintLastCountEvenOddNumbers(List<int> numbers, List<string> cmd)
        {
            int count = int.Parse(cmd[1]);
            if (count > numbers.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string evenOdd = cmd[2];
            List<int> lastCountEvenOddNums = new List<int>();
            if (evenOdd == "even")
            {
                for (int i = numbers.Count - 1; i>=0; i--)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        lastCountEvenOddNums.Insert(0, numbers[i]);
                    }
                    if (lastCountEvenOddNums.Count == count)
                        break;
                }
            }
            else
            {
                for (int i = numbers.Count -1 ; i >= 0; i--)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        lastCountEvenOddNums.Insert(0, numbers[i]);
                    }
                    if (lastCountEvenOddNums.Count == count)
                        break;
                }
            }
            Console.WriteLine("[" + string.Join(", ", lastCountEvenOddNums) + "]");
        }

        private static void PrintFirstCountEvenOddNumbers(List<int> numbers, List<string> cmd)
        {
            int count = int.Parse(cmd[1]);
            if(count>numbers.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string evenOdd = cmd[2];
            List<int> firstCountEvenOddNums = new List<int>();
            if (evenOdd == "even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        firstCountEvenOddNums.Add(numbers[i]);
                    }
                    if (firstCountEvenOddNums.Count == count)
                        break;
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        firstCountEvenOddNums.Add(numbers[i]);
                        if (firstCountEvenOddNums.Count == count)
                            break;
                    }
                }
            }
            Console.WriteLine("[" + string.Join(", ", firstCountEvenOddNums) + "]");
        }

        private static void PrintIndexOfMinEvenOddNumber(List<int> numbers, List<string> cmd)
        {
            string evenOdd = cmd[1];
            int minEvenOddNumber = 2000;
            int index = -1;
            if (evenOdd == "even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] <= minEvenOddNumber)
                    {
                        minEvenOddNumber = numbers[i];
                        index = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1 && numbers[i] <= minEvenOddNumber)
                    {
                        index = i;
                        minEvenOddNumber = numbers[i];
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine(index);
        }

        private static void PrintIndexOfMaxEvenOddNumber(List<int> numbers, List<string> cmd)
        {
            string evenOdd = cmd[1];
            int maxEvenOddNumber = -1;
            int index = -1;
            if (evenOdd == "even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] >= maxEvenOddNumber)
                    {
                        maxEvenOddNumber = numbers[i];
                        index = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1 && numbers[i] >= maxEvenOddNumber)
                    {
                        index = i;
                        maxEvenOddNumber = numbers[i];
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine(index);
        }

        private static void SwitchByIndex(List<int> numbers, List<string> cmd)
        {
            int splitBy = int.Parse(cmd[1]);
            if (splitBy < 0 || splitBy >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            for (int i = 0; i <= splitBy; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }
    }
}
