using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_HornetAssault
{
    public class HornetAssault
    {
        public static void Main()
        {
            List<long> beehives = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            List<long> hornets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                long countOfBees = beehives[i];

                long powerOfTheHornets = hornets.Sum();

                beehives[i] -= powerOfTheHornets;

                if (countOfBees >= powerOfTheHornets)
                {
                    hornets.RemoveAt(0);
                }
            }

            if (beehives.Any(x => x > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}

