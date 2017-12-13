using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_CODEPhoenixOscarRomeoNovember
{
    public class CODEPhoenixOscarRomeoNovember
    {
        public static void Main()
        {
            string input = string.Empty;
            Dictionary<string, List<string>> squads = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "Blaze it!")
            {
                var tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string creature = tokens[0];
                string SquadMate = tokens[1];

                if (!squads.ContainsKey(creature))
                {
                    squads.Add(creature, new List<string>());
                }
                if (!squads[creature].Contains(SquadMate) && SquadMate != creature)
                {
                    squads[creature].Add(SquadMate);
                }
            }

            Dictionary<string, List<string>> resultDictionary = new Dictionary<string, List<string>>();

            foreach (var pair in squads)
            {
                var creature = pair.Key;
                var squadMates = pair.Value;

                resultDictionary.Add(creature, new List<string>());

                foreach (var mate in squadMates)
                {
                    if (squads.ContainsKey(mate) && squads[mate].Contains(creature))
                    {
                        continue;
                    }

                    else
                    {
                        resultDictionary[creature].Add(mate);
                    }
                }
            }

            foreach (var pair in resultDictionary.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{pair.Key} : {pair.Value.Count}");
            }
        }
    }
}
