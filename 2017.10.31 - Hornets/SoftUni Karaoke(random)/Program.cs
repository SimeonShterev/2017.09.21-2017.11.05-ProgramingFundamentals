using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Karaoke_random_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participantsList = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToList();
            List<string> songsList = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToList();
            Dictionary<string, List<string>> participantsAwards = new Dictionary<string, List<string>>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(',').Select(p => p.Trim()).ToList();
                if (input[0] == "dawn")
                {
                    break;
                }
                string participant = input[0].Trim();
                string song = input[1].Trim();
                string award = input[2].Trim();
                if (participantsList.Contains(participant) && songsList.Contains(song))
                {
                    if (!(participantsAwards.ContainsKey(participant)))
                    {
                        participantsAwards.Add(participant, new List<string>());
                        participantsAwards[participant].Add(award);
                    }
                    else
                    {
                        participantsAwards[participant].Add(award);
                        participantsAwards[participant] = participantsAwards[participant].Distinct().ToList();
                    }
                }
            }
            if (participantsAwards.Count != 0)
            {
                foreach (var participantAward in participantsAwards.OrderByDescending(awards => awards.Value.Count()).ThenBy(name => name.Key))
                {
                    Console.WriteLine($"{participantAward.Key}: {participantAward.Value.Count} awards");
                    foreach (var award in participantAward.Value.OrderBy(award=>award))
                    {
                        Console.WriteLine("--" + award);
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
