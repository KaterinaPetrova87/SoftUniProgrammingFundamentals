using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Trainlands
{
    public class Trainlands
    {
        public static void Main()
        {
            string input = string.Empty;
            Dictionary<string, Dictionary<string, int>> trains = new Dictionary<string, Dictionary<string, int>>();

            while((input = Console.ReadLine()) != "It's Training Men!")
            {
                if(input.Contains("->") && input.Contains(":"))
                {
                    var tokens = input.Split(new[] { " -> ", " : " }, StringSplitOptions.RemoveEmptyEntries);
                    string trainName = tokens[0];
                    string wagonName = tokens[1];
                    int wagonPower = int.Parse(tokens[2]);

                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, int>());
                    }
                    trains[trainName].Add(wagonName, wagonPower);
                }
                else if (input.Contains("="))
                {
                    var tokens = input.Split(new[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
                    string trainName = tokens[0];
                    string otherTrainName = tokens[1];

                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, int>());
                    }
                    trains[trainName].Clear();
                    var otherTrain = trains[otherTrainName];
                    foreach (var wagon in otherTrain)
                    {
                        trains[trainName].Add(wagon.Key, wagon.Value);
                    }
                }
                else
                {
                    var tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    string trainName = tokens[0];
                    string otherTrainName = tokens[1];

                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, int>());
                    }
                    var otherTrain = trains[otherTrainName];
                    foreach (var wagon in otherTrain)
                    {
                        trains[trainName].Add(wagon.Key, wagon.Value);
                    }
                    trains.Remove(otherTrainName);
                }
            }

            foreach (var pair in trains.OrderByDescending(w => w.Value.Values.Sum()).ThenBy(w=>w.Value.Count))
            {
                Console.WriteLine($"Train: {pair.Key}");

                foreach (var item in trains[pair.Key].OrderByDescending(w=>w.Value))
                {
                    Console.WriteLine($"###{item.Key} - {item.Value}");
                }
            }
        }
    }
}
