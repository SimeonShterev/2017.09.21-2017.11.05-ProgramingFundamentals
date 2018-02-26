using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(' ');
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while (commands[0] != "END")
            {
                if (commands[0] == "A")
                {
                    phonebook.Remove(commands[1]);
                    phonebook.Add(commands[1], commands[2]);
                }
                if (commands[0] == "S")
                {
                    if (phonebook.ContainsKey(commands[1]))
                    {
                        Console.WriteLine("{0} -> {1} ", commands[1], phonebook[commands[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", commands[1]);
                    }
                }
                if(commands[0]=="ListAll")
                {
                    foreach (var name in phonebook)
                    {
                        Console.WriteLine($"{name.Key} -> {name.Value}");
                    }
                }
                commands = Console.ReadLine().Split(' ');
            }
        }
    }
}
