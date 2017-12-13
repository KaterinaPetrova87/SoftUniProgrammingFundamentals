using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_HandsOfCards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            while (input != "JOKER")
            {
                string[] command = input
                    .Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string playerName = command[0];
                string[] cards = command[1]
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!dictionary.ContainsKey(playerName))
                {
                    dictionary.Add(playerName, new List<string>());
                }
                dictionary[playerName].AddRange(cards);

                input = Console.ReadLine();
            }

            foreach (var player in dictionary)
            {
                List<string> cards = player.Value.Distinct().ToList();
                int sum = 0;

                foreach (var card in cards)
                {
                    string power = card.Substring(0, card.Length-1);
                    string powerOfType = card.Substring(card.Length-1);

                    int powerOfTheCard = GetPowerOfCard(power);
                    int powerOfTheType = GetPowerOfTheType(powerOfType);

                    sum += powerOfTheCard * powerOfTheType;
                }
                Console.WriteLine($"{player.Key}: {sum}");
            }
        }

        private static int GetPowerOfTheType(string powerOfType)
        {
            switch (powerOfType)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 1;
            }
        }

        public static int GetPowerOfCard(string power)
        {
            switch (power)
            {
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 1;
            }
        }
    }
}
