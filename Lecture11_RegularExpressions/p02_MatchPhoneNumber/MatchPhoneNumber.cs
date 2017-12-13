using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p02_MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string pattern = @"\+359(\s|\-)2(\1)\d{3}(\1)\d{4}\b";
            string phones = Console.ReadLine();

            var matches = Regex.Matches(phones, pattern);

            var matchedPhones = matches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
