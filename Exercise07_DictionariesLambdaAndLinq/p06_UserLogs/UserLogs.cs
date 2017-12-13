using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> dictionary = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                var command = input.Split(new[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var ip = command[1];
                var userName = command.Last();

                if (!dictionary.ContainsKey(userName))
                {
                    dictionary[userName] = new Dictionary<string, int>();
                }

                Dictionary<string, int> ipAdresses = dictionary[userName];

                if (!ipAdresses.ContainsKey(ip))
                {
                    ipAdresses[ip] = 0;
                }
                ipAdresses[ip]++;

                input = Console.ReadLine();
            }

            foreach (var user in dictionary)
            {
                Console.WriteLine($"{user.Key}: ");

                foreach (var adresses in user.Value)
                {
                    if (!adresses.Equals(user.Value.Last()))
                    {
                        Console.Write($"{adresses.Key} => {adresses.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{adresses.Key} => {adresses.Value}.");
                    }
                }
            }
        }
    }
}
