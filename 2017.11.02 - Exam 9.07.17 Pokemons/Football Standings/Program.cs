using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            Dictionary<string, List<int>> teamsScores = new Dictionary<string, List<int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }
                int index = input.IndexOf(key);
                input = input.Substring(index + key.Length);
                index = input.IndexOf(key);
                string firstTeamReversed = input.Remove(index).ToUpper();
                input = input.Substring(index + key.Length);
                index = input.IndexOf(key);
                input = input.Substring(index + key.Length);
                index = input.IndexOf(key);
                string secondTeamReversed = input.Remove(index).ToUpper();
                index = input.LastIndexOf(" ");
                string score = input.Substring(index + 1);
                char[] firstch = firstTeamReversed.ToCharArray();
                Array.Reverse(firstch);
                char[] secondch = secondTeamReversed.ToCharArray();
                Array.Reverse(secondch);
                string firstTeam = new string(firstch);
                string secondTeam = new string(secondch);

                List<int> scoreList = score.Split(':').Select(int.Parse).ToList();
                int firstTeamWinLose = 0;
                int secondTeamWinLose = 0;
                if (scoreList[0] > scoreList[1])
                {
                    firstTeamWinLose = 3;
                    secondTeamWinLose = 0;
                }
                if (scoreList[0] < scoreList[1])
                {
                    firstTeamWinLose = 0;
                    secondTeamWinLose = 3;
                }
                if (scoreList[0] == scoreList[1])
                {
                    firstTeamWinLose = 1;
                    secondTeamWinLose = 1;
                }
                if (!teamsScores.ContainsKey(firstTeam))
                {
                    teamsScores.Add(firstTeam, new List<int>());
                    teamsScores[firstTeam].Add(scoreList[0]);
                    teamsScores[firstTeam].Add(firstTeamWinLose);
                }
                else
                {
                    teamsScores[firstTeam][0] += scoreList[0];
                    teamsScores[firstTeam][1] += firstTeamWinLose;
                }
                if (!teamsScores.ContainsKey(secondTeam))
                {
                    teamsScores.Add(secondTeam, new List<int>());
                    teamsScores[secondTeam].Add(scoreList[1]);
                    teamsScores[secondTeam].Add(secondTeamWinLose);
                }
                else
                {
                    teamsScores[secondTeam][0] += scoreList[1];
                    teamsScores[secondTeam][1] += secondTeamWinLose;
                }
            }
            Console.WriteLine("League standings:");
            int count = 0;
            foreach (var team in teamsScores.OrderByDescending(teamPoints=>teamPoints.Value[1]).ThenBy(teamName=>teamName.Key))
            {
                count++;
                Console.WriteLine($"{count}. {team.Key} {team.Value[1]}");
            }
            Console.WriteLine("Top 3 scored goals:");
            int top3 = 0;
            foreach (var top3Teams in teamsScores.OrderByDescending(teamGoals=>teamGoals.Value[0]).ThenBy(teamName => teamName.Key))
            {
                Console.WriteLine($"- {top3Teams.Key} -> {top3Teams.Value[0]}");
                top3++;
                if (top3 == 3)
                    break;
            }
        }
    }
}
