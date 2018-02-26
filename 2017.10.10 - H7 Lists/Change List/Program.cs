using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "Odd" || input != "Even")
            {
                string[] array = input.Split(' ');
                string command = array[0];
                if (command == "Delete")
                {
                    int elementToDel = int.Parse(array[1]);
                    for(int i=0; i<list.Count;i++)
                    {
                        list.Remove(elementToDel);
                    }
                }
                if (command == "Insert")
                {
                    int elementToIns = int.Parse(array[1]);
                    int position = int.Parse(array[2]);
                    list.Insert(position, elementToIns);
                }
                if (command == "Even")
                {
                    for (int i = 0; i <= list.Count - 1; i++)
                    {
                        if(list[i]%2==0)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    break;
                }
                if (command == "Odd")
                {
                    for (int i = 0; i <= list.Count - 1; i++)
                    {
                        if (list[i] % 2 != 0)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine();
        }
    }
}
