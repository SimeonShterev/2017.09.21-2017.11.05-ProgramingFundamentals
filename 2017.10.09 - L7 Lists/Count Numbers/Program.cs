using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sortValues = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            sortValues.Sort();
            int count = 1;
            int pos = 0;
            while(pos<sortValues.Count)
            {
                if(sortValues[pos]==sortValues[pos+1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(sortValues[pos] + " -> " + count);
                    count = 1;
                }
                pos++;
            }
        }
    }
}
