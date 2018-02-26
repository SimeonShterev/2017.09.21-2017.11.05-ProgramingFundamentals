using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Evo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();
            while(true)
            {
                string[] input = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if(input.Length==1 && input[0]=="wubbalubbadubdub")
                {
                    break;
                }
                if(input.Length==1 && pokemons.ContainsKey(input[0]))
                {
                    Console.WriteLine($"# {input[0]}");
                    foreach(var value in pokemons[input[0]])
                    {
                        Console.WriteLine(value);
                    }
                }
                if(input.Length==3)
                {
                    string name = input[0];
                    string typeIndex = input[1] + " <-> " + input[2];
                    if(!pokemons.ContainsKey(name))
                    {
                        pokemons.Add(name, new List<string>());
                        pokemons[name].Add(typeIndex);
                    }
                    else
                    {
                        pokemons[name].Add(typeIndex);
                    }
                }
            }
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                var orderedValues = pokemon.Value.OrderByDescending(index => int.Parse(index.Split(' ')[2]));
                foreach (var value in orderedValues)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
