using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace p04_Weather
{
    public class Weather
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<double, string>> dictionary = new Dictionary<string, Dictionary<double, string>>();

            string pattern = @"([A-Z]{2})([0-9]*.[0-9]*)([A-z]{1,})\|";

            string input = Console.ReadLine();

            while (input != "end")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    string cityName = match.Groups[1].Value.ToString();
                    double cityTemperature = double.Parse(match.Groups[2].Value);
                    string cityWeather = match.Groups[3].Value;

                    if (dictionary.ContainsKey(cityName))
                    {
                        dictionary.Remove(cityName);
                    }
                    if (!dictionary.ContainsKey(cityName))
                    {
                        dictionary[cityName] = new Dictionary<double, string>();
                        dictionary[cityName].Add(cityTemperature, cityWeather);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var cityName in dictionary.OrderBy(x => x.Value.Keys.Average()))
            {
                foreach (var temper in cityName.Value)
                {
                    Console.WriteLine("{0} => {1:f2} => {2}", cityName.Key, temper.Key, temper.Value);
                }
            }
        }
    }
}
