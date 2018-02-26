using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Winning_Ticket_random_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()).ToArray();
            string pattern = @"[#]{6,10}|[\^]{6,10}|[@]{6,10}|[\$]{6,10}";
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim();
                if (input[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string leftHalf = new string(input[i].Take(10).ToArray());
                string rightHalf = new string(input[i].Skip(10).ToArray());
                Match leftMatch = Regex.Match(leftHalf, pattern);
                Match rightMatch = Regex.Match(rightHalf, pattern);
                bool someOfTheHalvesDoestSucceed = !(leftMatch.Success && rightMatch.Success);
                if (someOfTheHalvesDoestSucceed)
                {
                    Console.WriteLine($"ticket \"{input[i]}\" - no match");
                    continue;
                }
                bool bothHalvesSucceedWithDifferentSymbols = leftMatch.Success && rightMatch.Success && leftMatch.ToString()[0] != rightMatch.ToString()[0];
                if (bothHalvesSucceedWithDifferentSymbols)
                {
                    Console.WriteLine($"ticket \"{input[i]}\" - no match");
                    continue;
                }
                if (leftMatch.ToString().Contains(rightMatch.ToString()))
                {
                    bool jackpot = leftMatch.ToString().Length == 10 && rightMatch.ToString().Length == 10;
                    if (jackpot)
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - {rightMatch.Length}{rightMatch.ToString()[0]} Jackpot!");
                        continue;
                    }
                    Console.WriteLine($"ticket \"{input[i]}\" - {rightMatch.Length}{rightMatch.ToString()[0]}");
                    continue;
                }
                if (rightMatch.ToString().Contains(leftMatch.ToString()))
                {
                    Console.WriteLine($"ticket \"{input[i]}\" - {leftMatch.Length}{leftMatch.ToString()[0]}");
                }
            }

        }
    }
}

