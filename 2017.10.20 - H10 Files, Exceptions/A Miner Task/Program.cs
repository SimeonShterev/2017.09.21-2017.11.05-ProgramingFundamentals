using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "Gold", "155", "Silver", "10", "Copper", "17", "Gold", "15", "stop" };
            File.WriteAllLines(@"..\..\Input.txt", inputArray);
            string input = File.ReadAllText(@"..\..\Input.txt");
            List<string> data = input.Split(new string[] { "\r\n", " "}, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, long> resources = new Dictionary<string, long>();
            int count = 0;
            while (data[count]!="stop")
            {
                data.Add(input);
                if (count % 2 != 0)
                {
                    if (!resources.ContainsKey(data[count - 1]))
                    {
                        resources[data[count - 1]] = 0;
                    }
                    int quantity = int.Parse(data[count]);
                    if (resources.ContainsKey(data[count - 1]))
                    {
                        resources[data[count - 1]] += quantity;
                    }
                }
                count++;
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
                File.AppendAllText(@"..\..\Output.txt", $"{item.Key} -> {item.Value}" + "\r\n");
            }
        }
    }
}
