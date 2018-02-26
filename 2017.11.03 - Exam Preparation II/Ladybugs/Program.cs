using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long[] ladyBugs = new long[n];
            List<long> ladyBugsAt = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            for (int i = 0; i < ladyBugsAt.Count; i++)
            {
                if (ladyBugsAt[i] < 0 || ladyBugsAt[i] >= ladyBugs.Length)
                    continue;
                ladyBugs[ladyBugsAt[i]] = 1;
            }
            while (true)
            {
                List<string> cmd = Console.ReadLine().Split(' ').ToList();
                if (cmd[0] == "end")
                    break;
                switch (cmd[1])
                {

                    case "right":
                        MoveLadybugToTheRight(ladyBugs, cmd);
                        break;
                    case "left":
                        MoveLadybugToTheLeft(ladyBugs, cmd);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", ladyBugs));
        }

        static void MoveLadybugToTheRight(long[] ladyBugs, List<string> cmd)
        {
            long index = long.Parse(cmd[0]);
            long flyLength = long.Parse(cmd[2]);
            if (index < 0 || index >= ladyBugs.Length)
                return;
            if (ladyBugs[index] == 0)
                return;
            ladyBugs[index] = 0;
            while (true)
            {
                if (index + flyLength >= ladyBugs.Length || index + flyLength < 0)
                {
                    break;
                }
                else if (ladyBugs[index + flyLength] == 0)
                {
                    ladyBugs[index + flyLength] = 1;
                    break;
                }
                index += flyLength;
            }
        }

        private static void MoveLadybugToTheLeft(long[] ladyBugs, List<string> cmd)
        {
            long index = long.Parse(cmd[0]);
            long flyLength = long.Parse(cmd[2]);
            if (index < 0 || index >= ladyBugs.Length)
                return;
            if (ladyBugs[index] == 0)
                return;
            ladyBugs[index] = 0;
            while (true)
            {
                if (index - flyLength < 0 || index - flyLength >= ladyBugs.Length)
                {
                    break;
                }
                else if (ladyBugs[index - flyLength] == 0)
                {
                    ladyBugs[index - flyLength] = 1;
                    break;
                }
                index -= flyLength;
            }
        }
    }
}
