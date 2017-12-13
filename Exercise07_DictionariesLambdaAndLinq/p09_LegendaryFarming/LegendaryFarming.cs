using System;
using System.Collections.Generic;
using System.Linq;

namespace p09_LegendaryFarming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            bool hasObtained = false;

            while (!hasObtained)
            {
                var input = Console.ReadLine()
                .ToLower()
                .Split(' ');

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials.Values.Any(q => q >= 250))
                        {
                            keyMaterials[material] -= 250;

                            string obtainedItem = "";

                            switch (material)
                            {
                                case "shards":
                                    obtainedItem = "Shadowmourne";
                                    break;

                                case "fragments":
                                    obtainedItem = "Valanyr";
                                    break;

                                case "motes":
                                    obtainedItem = "Dragonwrath";
                                    break;
                            }
                            hasObtained = true;
                            Console.WriteLine($"{obtainedItem} obtained!");
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }

                        junkMaterials[material] += quantity;
                    }
                }
            }
            foreach (var pair in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            foreach (var pair in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
