using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Roli_the_Coder_second_try
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<string>> eventNamesParticipants = new Dictionary<int, List<string>>();
            List<string> eventsList = new List<string>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(' ').Select(data => data.Trim()).ToList();
                if (input[0] == "Time")
                    break;
                if (CheckValidity(input))
                    continue;
                int id = int.Parse(input[0]);
                string eventName = input[1].Substring(1);
                if (!eventNamesParticipants.ContainsKey(id))
                {
                    if (eventsList.Contains(eventName))
                        continue;
                    if (!eventsList.Contains(eventName))
                        eventsList.Add(eventName);
                    eventNamesParticipants.Add(id, new List<string>());
                    eventNamesParticipants[id].Add(eventName);
                    for (int i = 2; i < input.Count; i++)
                    {
                        eventNamesParticipants[id].Add(input[i]);
                    }
                    eventNamesParticipants[id] = eventNamesParticipants[id].Distinct().ToList();
                }
                if (eventNamesParticipants.ContainsKey(id) && eventNamesParticipants[id][0] == eventName)
                {
                    for (int i = 2; i < input.Count; i++)
                    {
                        eventNamesParticipants[id].Add(input[i]);
                    }
                    eventNamesParticipants[id] = eventNamesParticipants[id].Distinct().ToList();
                }
            }
            foreach (var events in eventNamesParticipants.OrderByDescending(participants => participants.Value.Count).ThenBy(events => events.Value[0]))
            {
                Console.WriteLine($"{events.Value[0]} - {events.Value.Count - 1}");
                foreach (var participant in events.Value.OrderBy(name => name))
                {
                    if (!participant.StartsWith("@"))
                        continue;
                    Console.WriteLine(participant);
                }
            }
        }
        static bool CheckValidity(List<string> input)
        {
            if (!input[1].StartsWith("#"))
                return true;
            for (int i = 2; i < input.Count; i++)
            {
                Match match = Regex.Match(input[i], @"^@[a-zA-Z-'0-9]+$");
                if (!match.Success)
                    return true;
            }
            return false;
        }
    }
}
