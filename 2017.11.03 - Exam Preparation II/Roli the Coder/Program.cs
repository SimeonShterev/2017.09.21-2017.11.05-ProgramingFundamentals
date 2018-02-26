using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Roli_the_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, List<string>>> eventParticipants = new Dictionary<string, SortedDictionary<string, List<string>>>();
            while (true)
            {
                List<string> data = Console.ReadLine().Split(' ').Select(values => values.Trim()).ToList();
                if (data[0] == "Time")
                    break;
                if (CheckValidity(data))
                    continue;
                string id = data[0];
                string eventName = data[1].Substring(1);
                if (!eventParticipants.ContainsKey(id))
                {
                    eventParticipants.Add(id, new SortedDictionary<string, List<string>>());
                    eventParticipants[id].Add(eventName, new List<string>());
                    for (int i = 2; i < data.Count; i++)
                    {
                        eventParticipants[id][eventName].Add(data[i]);
                    }
                }
                else
                {
                    if (eventParticipants[id].ContainsKey(eventName))
                    {
                        for (int i = 2; i < data.Count; i++)
                        {
                            eventParticipants[id][eventName].Add(data[i]);
                        }
                    }
                    else
                        continue;
                    eventParticipants[id][eventName] = eventParticipants[id][eventName].Distinct().ToList();
                }
            }
            foreach (var events in eventParticipants.OrderByDescending(evennt => evennt.Value.Values.Sum(x => x.Count)))
            {
                foreach (var eventt in events.Value)
                {
                    Console.WriteLine($"{eventt.Key} - {eventt.Value.Count}");
                    foreach (var item in eventt.Value.OrderBy(name => name))
                    {
                        Console.WriteLine(string.Join("\n", item));
                    }
                }
            }
        }

        static bool CheckValidity(List<string> data)
        {
            if (!data[1].StartsWith("#"))
                return true;
            for (int i = 2; i < data.Count; i++)
            {
                Match match = Regex.Match(data[i], @"@[a-zA-Z-'0-9]+$");
                if (!match.Success)
                    return true;
            }
            return false;
        }
    }
}

