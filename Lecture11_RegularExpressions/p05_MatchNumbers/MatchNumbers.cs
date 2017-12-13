using System;
using System.Text.RegularExpressions;

namespace p05_MatchNumbers
{
    public class MatchNumbers
    {
        public static void Main()
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string input = Console.ReadLine();

            MatchCollection datesMatches = Regex.Matches(input, pattern);

            foreach (Match date in datesMatches)
            {
                Console.Write(date + " ");
            }
        }
    }
}
