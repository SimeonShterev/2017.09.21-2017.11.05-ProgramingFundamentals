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
            List <int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "print")
            {
                string[] commandArray = input.Split(' ');
                string command = commandArray[0];
                if (command == "add")
                {
                    list.Insert(int.Parse(commandArray[1]), int.Parse(commandArray[2]));
                }
                if (command == "addMany")
                {
                    for (int i = 2; i < commandArray.Length; i++)
                    {
                        list.Insert((int.Parse(commandArray[1])) + i - 2, int.Parse(commandArray[i]));
                    }
                }
                if (command == "contains")
                {
                    if (list.Contains(int.Parse(commandArray[1])))
                    {
                        Console.WriteLine(list.IndexOf(int.Parse(commandArray[1])));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                if (command == "remove")
                {
                    list.RemoveAt(int.Parse(commandArray[1]));
                }
                if (command == "shift")
                {
                    int number = int.Parse(commandArray[1]);
                    number = number % list.Count;
                    List<int> temp = list.Take(number).ToList();
                    list.RemoveRange(0, number);
                    list.AddRange(temp);
                }
                if(command=="sumPairs")
                {
                    for(int i = 0; i<list.Count - 1; i ++)
                    {
                        int sum = list[i] + list[i + 1];
                        list[i] = sum;
                        list.RemoveAt(i + 1);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }
    }
}
