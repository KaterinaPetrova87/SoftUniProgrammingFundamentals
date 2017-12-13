using System;
using System.Collections.Generic;
using System.Linq;

namespace p08_LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                string ip = input[0];
                string userName = input[1];
                int logs = int.Parse(input[2]);

                if (!userLogs.ContainsKey(userName))
                {
                    userLogs.Add(userName, new Dictionary<string, int>());
                }

                if (!userLogs[userName].ContainsKey(ip))
                {
                    userLogs[userName].Add(ip, logs);
                }
                else
                {
                    userLogs[userName][ip] += logs;
                }
            }
            foreach (var user in userLogs)
            {
                var name = user.Key;
                var totalLogs = userLogs[name].Values.Sum();
                var ipList = user.Value.Keys.OrderBy(x => x).ToList();

                Console.WriteLine($"{name}: {totalLogs} [{string.Join(", ", ipList)}]");
            }
        }
    }
}
