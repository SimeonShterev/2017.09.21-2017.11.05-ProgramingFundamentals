using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> dict = new SortedDictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split(' ');
                string name = data[1];
                string IP = data[0];
                int duration = int.Parse(data[2]);
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new Dictionary<string, int>());
                }
                if (!dict[name].ContainsKey(IP))
                {
                    dict[name].Add(IP, duration);
                }
                else
                {
                    dict[name][IP] += duration;
                }
            }
            foreach (var user in dict)
            {
                var totalDurationOfUser = dict[user.Key].Values.Sum();
                var IPs = string.Join(", ", user.Value.Keys.OrderBy(x => x));
                Console.WriteLine($"{user.Key}: {totalDurationOfUser} [{IPs}]");
            }
        }
    }
}
