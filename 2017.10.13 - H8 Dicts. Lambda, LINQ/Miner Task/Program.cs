using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> data = new List<string>();
            Dictionary<string, long> resources = new Dictionary<string, long>();
            int count = 1;
            while (input != "stop")
            {
                data.Add(input);
                if (count % 2 == 0)
                {
                    if (!resources.ContainsKey(data[count - 2]))
                    {
                        resources[data[count - 2]] = 0;
                    }
                    int quantity = int.Parse(data[count - 1]);
                    if (resources.ContainsKey(data[count - 2]))
                    {
                        resources[data[count - 2]] += quantity;
                    }
                }
                input = Console.ReadLine();
                count++;
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
