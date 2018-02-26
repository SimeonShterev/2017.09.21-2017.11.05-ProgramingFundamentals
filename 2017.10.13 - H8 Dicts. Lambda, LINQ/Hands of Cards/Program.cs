using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> people = new Dictionary<string, Dictionary<string, int>>();
            while (input != "JOKER")
            {
                string[] commandArgs = input.Split(':');
                string name = commandArgs[0];
                string[] cardArgs = commandArgs[1].Trim().Split(new string[] { ", " },  StringSplitOptions.RemoveEmptyEntries);
                if(!people.ContainsKey(name))
                {
                    people.Add(name, new Dictionary<string, int>());
                    AddCardToPerson(people[name], cardArgs);
                }
                else
                {
                    AddCardToPerson(people[name], cardArgs);
                }
                input = Console.ReadLine();
            }
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key}: {person.Value.Values.Sum()}");
            }
        }

        static void AddCardToPerson(Dictionary<string, int> person, string[] cardArgs)
        {
           
            foreach (var card in cardArgs)
            {
                if(!person.ContainsKey(card))
                {
                    person.Add(card, GetValue(card));
                }
            }
        }

        static int GetValue(string card)
        {
            int power = 0;
            switch (card.First())
            {
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8': 
                case '9': power += (int)card.First() - 48; break;
                case '1': power += 10; break;
                case 'J': power += 11; break;
                case 'Q': power += 12; break;
                case 'K': power += 13; break;
                case 'A': power += 14; break;
            }
            switch (card.Last())
            {
                case 'S': power *= 4; break;
                case 'H': power *= 3; break;
                case 'D': power *= 2; break;
                case 'C': power *= 1; break;
            }
            return power;
        }
    }
}
