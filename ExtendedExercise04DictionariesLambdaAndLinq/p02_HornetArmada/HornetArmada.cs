using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_HornetArmada
{
    public class HornetArmada
    {
        public static void Main()
        {
            var legionSoldiers = new Dictionary<string, Dictionary<string, long>>();
            var legionActivities = new Dictionary<string, long>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new[] { '=', '-', '>', ':', ' ' }
                    , StringSplitOptions.RemoveEmptyEntries);

                long lastActivity = long.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                long soldierCount = long.Parse(tokens[3]);

                if (!legionActivities.ContainsKey(legionName))
                {
                    legionActivities.Add(legionName, lastActivity);
                    legionSoldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (!legionSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionSoldiers[legionName][soldierType] = 0;
                }

                if (legionActivities[legionName] < lastActivity)
                {
                    legionActivities[legionName] = lastActivity;
                }

                legionSoldiers[legionName][soldierType] += soldierCount;
            }

            string[] commands = Console.ReadLine().Split('\\');

            if (commands.Length == 1)
            {
                string soldierType = commands[0];
                foreach (var legion in legionActivities.OrderByDescending(l => l.Value))
                {
                    if (legionSoldiers[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
            else
            {
                int activity = int.Parse(commands[0]);
                string soldierType = commands[1];

                foreach (var legion in legionSoldiers.Where(l => l.Value.ContainsKey(soldierType))
                    .OrderByDescending(l => l.Value[soldierType]))
                {
                    if (legionActivities[legion.Key] < activity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[soldierType]}");
                    }
                }
            }
        }
    }
}
