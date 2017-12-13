using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03_MatchHexadecimalNumbers
{
    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();

            var hexadecimalNumbers = Regex.Matches(input, pattern)
                .Cast<Match>()
                .Select(n => n.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", hexadecimalNumbers));
        }
    }
}
