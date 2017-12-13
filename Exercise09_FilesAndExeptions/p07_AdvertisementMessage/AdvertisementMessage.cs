using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p07_AdvertisementMessage
{
    public class AdvertisementMessage
    {
        public static void Main()
        {
            var input = File.ReadAllText("../../input.txt");
            input.ToArray();
            Random random = new Random();

            foreach (var item in input)
            {
                input = $"{Title(random.Next())} {Statement(random.Next())} {Author(random.Next())} – {City(random.Next())}."
                     + Environment.NewLine;
            }
            File.AppendAllText("../../output.txt", input);
        }

        private static string City(int index)
        {
            string[] cities =
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            return cities[index % cities.Length];
        }

        private static string Author(int index)
        {
            string[] authors =
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva",
                "Ani",
                "Antoaneta",
                "Silviq",
                "Tatqna",
                "Emanuela",
                "Andrea",
                "Gergana",
                "Petq",
                "Gery",
                "Jana",
                "Yana"
            };

            return authors[index % authors.Length];
        }

        private static string Statement(int index)
        {
            string[] statements =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles.I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            return statements[index % statements.Length];
        }

        private static string Title(int index)
        {
            string[] titles =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            return titles[index % titles.Length];
        }
    }
}
