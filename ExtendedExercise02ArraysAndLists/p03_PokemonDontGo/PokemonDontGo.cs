using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_PokemonDontGo
{
    public class PokemonDontGo
    {
        public static void Main()
        {
            List<long> distances = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            long sum = 0;

            while (distances.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                long removed = 0l;

                if (index < 0)
                {
                    removed = distances[0];
                    distances[0] = distances[distances.Count-1];
                }
                else if (index > distances.Count - 1)
                {
                    removed = distances[distances.Count - 1];
                    distances[distances.Count - 1] = distances[0];
                }
                else
                {
                    removed = distances[index];
                    distances.RemoveAt(index);
                }
                sum += removed;
                for (int i = 0; i < distances.Count; i++)
                {
                    if (distances[i] <= removed)
                    {
                        distances[i] += removed;
                    }
                    else
                    {
                        distances[i] -= removed;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
