using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^0-9-+\/*.]";
            string damagePattern = @"-?[0-9.]+|\+?[0-9.]+";
            List<string> input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            Dictionary<string, List<double>> nameHealthDamage = new Dictionary<string, List<double>>();
            for (int i = 0; i < input.Count; i++)
            {
                int health = 0;
                health = CalculateHealth(input, health, healthPattern, i);
                double damage = 0.0;
                damage = CalculateDamage(input, damage, damagePattern, i);
                nameHealthDamage.Add(input[i], new List<double>());
                nameHealthDamage[input[i]].Add(health);
                nameHealthDamage[input[i]].Add(damage);
            }
            foreach (var demon in nameHealthDamage.OrderBy(name=>name.Key))
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]:f0} health, {demon.Value[1]:f2} damage ");
            }
        }

        static double CalculateDamage(List<string> input, double damage, string damagePattern, int i)
        {
            MatchCollection damageMatch = Regex.Matches(input[i], damagePattern);
            foreach (Match match in damageMatch)
            {
                damage += double.Parse(match.ToString());
            }
            MatchCollection multiplyDivide = Regex.Matches(input[i], @"[\/*]");
            foreach (Match match in multiplyDivide)
            {
                if (match.ToString() == "/")
                {
                    damage /= 2;
                }
                if (match.ToString() == "*")
                {
                    damage *= 2;
                }
            }
            return damage;
        }

        static int CalculateHealth(List<string> input, int health, string healthPattern, int i)
        {
            MatchCollection healthMatch = Regex.Matches(input[i], healthPattern);
            foreach (Match match in healthMatch)
            {
                char[] letter = match.ToString().ToCharArray();
                health += letter[0];
            }
            return health;
        }
    }
}
