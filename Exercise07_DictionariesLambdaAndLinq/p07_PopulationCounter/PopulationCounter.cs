using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split('|')
                .ToArray();
            Dictionary<string, Dictionary<string, long>> countryWithCities = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);

                if (!countryWithCities.ContainsKey(country))
                {
                    countryWithCities.Add(country, new Dictionary<string, long>());
                }
                countryWithCities[country].Add(city, population);

                input = Console.ReadLine()
                    .Split('|')
                    .ToArray();
            }
            Dictionary<string, long> totalPopulation = new Dictionary<string, long>();

            foreach (var country in countryWithCities)
            {
                string currentCountry = country.Key;
                totalPopulation.Add(currentCountry, 0);

                foreach (var city in countryWithCities[currentCountry])
                {
                    totalPopulation[currentCountry] += city.Value;
                }
            }

            foreach (var country in totalPopulation.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

                foreach (var value in countryWithCities[country.Key].OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{value.Key}: {value.Value}");
                }
            }
        }
    }
}
