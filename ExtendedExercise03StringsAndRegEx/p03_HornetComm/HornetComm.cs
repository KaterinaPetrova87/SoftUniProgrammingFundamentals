using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace p03_HornetComm
{
    public class HornetComm
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string messagesPattern = @"^(\d+) <-> ([A-Za-z0-9]+)$";
            string broadcastsPattern = @"^(\D+) <-> ([A-Za-z0-9]+)$";

            //Regex messageRegex = new Regex(messagesPattern);
            //Regex broadcastRegex = new Regex(broadcastsPattern);

            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            while (input != "Hornet is Green")
            {
                var query = input.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (Regex.IsMatch(input, messagesPattern))
                {
                    var reversed = query[0].ToCharArray().Reverse().ToArray();
                    messages.Add($"{new string(reversed)} -> {query[1]}");
                }
                else if (Regex.IsMatch(input, broadcastsPattern))
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (var ch in query[1].ToCharArray())
                    {
                        if (char.IsUpper(ch))
                        {
                            sb.Append(char.ToLower(ch));
                        }
                        else if (char.IsLower(ch))
                        {
                            sb.Append(char.ToUpper(ch));
                        }
                        else
                        {
                            sb.Append(ch);
                        }
                    }

                    broadcasts.Add($"{sb.ToString()} -> {query[0]}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Any())
            {
                Console.WriteLine(string.Join($"{Environment.NewLine}", broadcasts));
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Any())
            {
                Console.WriteLine(string.Join($"{Environment.NewLine}", messages));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
