using System;
using System.Collections.Generic;

namespace p03_AMinerTask
{
    public class AMinerTask
    {
        public static void Main()
        {
            string resourceType = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (resourceType != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resourceType))
                {
                    resources.Add(resourceType, 0);
                }
                resources[resourceType] += quantity;

                resourceType = Console.ReadLine();
            }

            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
