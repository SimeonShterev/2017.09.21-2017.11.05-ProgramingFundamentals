using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Interpretator_Nakov
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(' ').ToList();
            while (true)
            {
                var commmandLine = Console.ReadLine();
                if (commmandLine == "end")
                {
                    break;
                }
                var cmdTokens = commmandLine.Split(' ');
                var cmdName = cmdTokens[0];
                var cmdParms = cmdTokens.Skip(1).ToArray();
                switch (cmdName)
                {
                    case "reverse":
                        ReverseList(items, cmdTokens);
                        break;
                    case "sort":
                        SortList(items, cmdTokens);
                        break;
                    case "rollLeft":
                        RolLeftList(items, cmdTokens);
                        break;
                    case "rollRight":
                        RollRightist(items, cmdTokens);
                        break;
                    default:
                        Console.WriteLine("Invalid Command");
                        break;
                }
                Console.WriteLine($"[{string.Join(", ", items)}]");
            }
        }

        static void RollRightist(List<string> items, string[] cmdTokens)
        {
            throw new NotImplementedException();
        }

        static void RolLeftList(List<string> items, string[] cmdTokens)
        {
            int count = int.Parse(cmdTokens[1]);
            if (count >= 0)
                RollListList(items, count);
        }

        private static void RollListList(List<string> items, int count)
        {
            for (int i = 0; i < items.Count; i++)
            {
                var newPos = (i + count);
                if (newPos < 0)
                    newPos += items.Count;
                if (newPos > 0)
                    newPos -= items.Count;
            }
        }

        static void SortList(List<string> items, int startIndex, int count)
        {
            var leftList = items.Take(startIndex - 1);
            var middleList = items.Skip(startIndex).Take(count).OrderBy(x => x);
            var rightList = items.Skip(startIndex + count);
            var allItems = leftList.Concat(middleList).Concat(rightList);
            var index = 0;
            foreach (var item in allItems.ToList())
            {
                items[index++] = item;
            }
        }

        static void ReverseList(List<string> items, string[] cmdTokens)
        {
            var startIndex = int.Parse(cmdTokens[2]);
            var count = int.Parse(cmdTokens[4]);
            if (IsValidRange(items, startIndex, count))
            {

            }
            else
            {

            }
        }

        static bool IsValidRange(List<string> items, int startIndex, int count)
        {
            if (startIndex < 0)
                return false;
            if (count < 0)
                return false;
            if (startIndex + count - 1 < items.Count)
                return true;
            else
                return false;
        }
    }
}
