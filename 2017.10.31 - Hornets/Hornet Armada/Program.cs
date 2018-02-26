using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            List<string> data = new List<string>();
            Dictionary<string, Dictionary<string, long>> legionSoldierTypeCount = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> legionLastActivity = new Dictionary<string, long>();
            for (long i = 0; i < n; i++)
            {
                StoreDataInDictionaries(data, legionLastActivity, legionSoldierTypeCount);
            }
            string[] cmd = Console.ReadLine().Split('\\').ToArray();
            if (cmd.Length == 2)
            {
                PrlongLegionNamesAndSoldierCount(cmd, legionLastActivity, legionSoldierTypeCount);
            }
            else
            {
                PrlongActivityAndLegionName(cmd, legionSoldierTypeCount, legionLastActivity);
            }
        }

        private static void PrlongActivityAndLegionName(string[] cmd, Dictionary<string, Dictionary<string, long>> legionSoldierTypeCount, Dictionary<string, long> legionLastActivity)
        {
            string soldierType = cmd[0];
            foreach (var legion in legionLastActivity
                .Where(legion => legionSoldierTypeCount[legion.Key].ContainsKey(soldierType))
                .OrderByDescending(legion => legion.Value))
            {
                Console.WriteLine($"{legionLastActivity[legion.Key]} : {legion.Key}");
            }
        }

        private static void PrlongLegionNamesAndSoldierCount(string[] cmd, Dictionary<string, long> legionLastActivity, Dictionary<string, Dictionary<string, long>> legionSoldierTypeCount)
        {
            long activity = long.Parse(cmd[0]);
            string soldierType = cmd[1];
            foreach (var legionName in legionSoldierTypeCount
                .Where(legion=>legion.Value.ContainsKey(soldierType))
                .Where(legion => legionLastActivity[legion.Key] < activity)
                .OrderByDescending(legion => legion.Value[soldierType]))
            {
                Console.WriteLine($"{legionName.Key} -> {legionName.Value[soldierType]}");
            }
        }

        static void StoreDataInDictionaries(List<string> data, Dictionary<string, long> legionLastActivity, Dictionary<string, Dictionary<string, long>> legionSoldierTypeCount)
        {
            data = Console.ReadLine().Split(new string[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            long lastActivity = long.Parse(data[0]);
            string legionName = data[1];
            string soldierType = data[2];
            long soldierCount = long.Parse(data[3]);
            if (!(legionLastActivity.ContainsKey(legionName)))
            {
                legionLastActivity.Add(legionName, lastActivity);
            }
            else
            {
                if (lastActivity > legionLastActivity[legionName])
                {
                    legionLastActivity[legionName] = lastActivity;
                }
            }
            StoreDataInLegionSoldierTypeCountDict(legionSoldierTypeCount, legionName, soldierType, soldierCount);
        }

        static void StoreDataInLegionSoldierTypeCountDict(Dictionary<string, Dictionary<string, long>> legionSoldierTypeCount, string legionName, string soldierType, long soldierCount)
        {
            if (!(legionSoldierTypeCount.ContainsKey(legionName)))
            {
                legionSoldierTypeCount.Add(legionName, new Dictionary<string, long>());
                if (!(legionSoldierTypeCount[legionName].ContainsKey(soldierType)))
                {
                    legionSoldierTypeCount[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    legionSoldierTypeCount[legionName][soldierType] += soldierCount;
                }
            }
            else
            {
                if (!(legionSoldierTypeCount[legionName].ContainsKey(soldierType)))
                {
                    legionSoldierTypeCount[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    legionSoldierTypeCount[legionName][soldierType] += soldierCount;
                }
            }
        }
    }
}
