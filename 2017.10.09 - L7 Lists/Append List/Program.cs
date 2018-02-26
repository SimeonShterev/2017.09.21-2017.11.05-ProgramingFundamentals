using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tokens = Console.ReadLine().Split('|').ToList();
            List<int> result = new List<int>();
            for(int i =tokens.Count - 1;i>=0;i--)
            {
                int[] collection = tokens[i].
                    Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                result.AddRange(collection);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
