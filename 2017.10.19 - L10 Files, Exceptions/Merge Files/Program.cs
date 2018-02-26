using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = File.ReadAllText(@"..\..\FileOne.txt");
            string two = File.ReadAllText(@"..\..\FileTwo.txt");
            int[] common = (one + " " + two).Split(new string[] { "\r\n", " "}, StringSplitOptions.None).Select(int.Parse).ToArray();
            Array.Sort(common);
            string str = string.Join("\r\n", common);
            File.WriteAllText(@"..\..\Output.txt", str);
        }
    }
}
