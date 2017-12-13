using System;
using System.Text.RegularExpressions;

namespace p02_ExtractSentencesByKeyword
{
    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string word = Console.ReadLine();

            string[] text = Console.ReadLine()
                .Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string pattern = $@"(\b{word}\b)";

            foreach (string sentence in text)
            {
                Match match = Regex.Match(sentence, pattern);

                if (match.Success)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
