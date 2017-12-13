using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_PokemonEvolution
{
    public class PokemonEvolution
    {
        public static void Main()
        {
            string input = string.Empty;
            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "wubbalubbadubdub")
            {
                var tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 1)
                {
                    string pokemonName = tokens[0];
                    string evolutionType = tokens[1];
                    int evolutionIndex = int.Parse(tokens[2]);

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons.Add(pokemonName, new List<string>());
                    }
                    pokemons[pokemonName].Add($"{evolutionType} <-> {evolutionIndex}");
                }
                else
                {
                    string pokemonName = tokens[0];
                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var item in pokemons[pokemonName])
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }

            foreach (var poke in pokemons)
            {
                var pokeName = poke.Key;
                Console.WriteLine($"# {pokeName}");
                var ordered = poke
                    .Value
                    .OrderByDescending(x => int.Parse(x.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)[1]));

                foreach (var item in ordered)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

