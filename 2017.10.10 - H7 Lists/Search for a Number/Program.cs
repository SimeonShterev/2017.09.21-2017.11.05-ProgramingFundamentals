using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] manipulatingArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> manipulatedList = new List<int>();
            for (int i = 0; i<manipulatingArray[0];i++)
            {
                manipulatedList.Add(list[i]);
            }
            for (int i = manipulatingArray[1] - 1; i >=0; i--)
            {
                manipulatedList.RemoveAt(i);
            }

            if(manipulatedList.Contains(manipulatingArray[2]))
                Console.WriteLine("YES!");
            else
                Console.WriteLine("NO!");        }
    }
}
