using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_CitiesByContinentAndCountry
{
    public class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split()
                    .ToArray();
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new Dictionary<string, List<string>>();
                }
                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new List<string>();
                }
                    continentsData[continent][country].Add(city);
            }

            foreach (var continent in continentsData)
            {
                string continentName = continent.Key;
                Dictionary<string, List<string>> countryWithCities = continent.Value;

                Console.WriteLine($"{continentName}:");
                foreach (var country in countryWithCities)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
