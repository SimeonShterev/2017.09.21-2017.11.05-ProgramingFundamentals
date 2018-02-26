using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Interpretator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (cmd[0] == "end")
                {
                    break;
                }
                switch (cmd[0])
                {
                    case "reverse":
                        ReverseElements(cmd, input);
                        break;
                    case "sort":
                        SortElements(cmd, input);
                        break;
                    case "rollLeft":
                        RollLeftElements(cmd, input);
                        break;
                    case "rollRight":
                        RollRightElements(cmd, input);
                        break;
                }
            }
            Console.WriteLine("[" + string.Join(", ", input) + "]");
        }

        private static void RollRightElements(string[] cmd, List<string> input)
        {
            int count = int.Parse(cmd[1]);
            if (IsValidCount(input, count))
            {
                count = count % input.Count;
                for (int i = 0; i < count; i++)
                {
                    input.Insert(0, input[input.Count - 1]);
                    input.RemoveAt(input.Count - 1);
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        static void RollLeftElements(string[] cmd, List<string> input)
        {
            int count = int.Parse(cmd[1]);
            if (IsValidCount(input, count))
            {
                count = count % input.Count;
                for (int i = 0; i < count; i++)
                {
                    input.Add(input[0]);
                    input.Remove(input[0]);
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        private static bool IsValidCount(List<string> input, int count)
        {
            if (count < 0)
                return false;
            else
                return true;
        }

        static void SortElements(string[] cmd, List<string> input)
        {
            int startIndex = int.Parse(cmd[2]);
            int count = int.Parse(cmd[4]);
            if (IsValidStarIndexPlusCount(input, startIndex, count))
            {
                input.Sort(startIndex, count, null);
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        static void ReverseElements(string[] cmd, List<string> input)
        {
            int startIndex = int.Parse(cmd[2]);
            int count = int.Parse(cmd[4]);
            if (IsValidStarIndexPlusCount(input, startIndex, count))
            {
                for (int i = 0; i < count / 2; i++)
                {
                    string oldvalue = input[startIndex + i];
                    string newValue = input[startIndex + count - 1 - i];
                    input[startIndex + i] = newValue;
                    input[startIndex + count - 1 - i] = oldvalue;
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        static bool IsValidStarIndexPlusCount(List<string> input, int startIndex, int count)
        {
            if (startIndex < 0 || startIndex >= input.Count)
                return false;
            if (count < 0 || (startIndex + count) > input.Count)
                return false;
            if (startIndex >= 0 && startIndex < input.Count() && count >= 0 && (startIndex + count) <= input.Count)
                return true;
            else
                return false;
        }
    }
}
