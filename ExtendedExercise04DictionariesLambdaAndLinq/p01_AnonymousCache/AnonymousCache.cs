using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_AnonymousCache
{
    public class AnonymousCache
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "thetinggoesskrra")
            {
                var tokens = input.Split(new[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 1)
                {
                    string dataSet = tokens[0];
                    cache.Add(dataSet, new Dictionary<string, long>());
                }
                else
                {
                    string dataKey = tokens[0];
                    long dataSize = long.Parse(tokens[1]);
                    string dataSet = tokens[2];

                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                    }
                    data[dataSet][dataKey] = dataSize;
                }
                input = Console.ReadLine();
            }
            if (cache.Count > 0)
            {
                var result = data.OrderByDescending(x => x.Value.Sum(e => e.Value)).First();
       
                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(e => e.Value)}");

                foreach (var pair in result.Value)
                {
                    Console.WriteLine($"$.{pair.Key}");
                }
            }
        }
    }
}
