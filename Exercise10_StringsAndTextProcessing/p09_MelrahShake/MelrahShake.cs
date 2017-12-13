using System;
using System.Text;

namespace p09_MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            var randomCharacters = Console.ReadLine();
            var pattern = Console.ReadLine();

            var sb = new StringBuilder();

            while (true)
            {
                var firstMatch = randomCharacters.IndexOf(pattern);
                var lastMatch = randomCharacters.LastIndexOf(pattern);

                if (firstMatch >= 0 && lastMatch >= 0 && pattern.Length > 0)
                {
                    randomCharacters = randomCharacters.Remove(lastMatch, pattern.Length);
                    randomCharacters = randomCharacters.Remove(firstMatch, pattern.Length);

                    sb.AppendLine("Shaked it.");

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    sb.AppendLine("No shake.");
                    break;
                }
            }
            Console.Write(sb.ToString());
            Console.WriteLine(randomCharacters);
        }
    }
}
