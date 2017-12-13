using System;
using System.Text.RegularExpressions;

namespace p01_MatchFullName
{
    public class MatchFullName
    {
        public static void Main()
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.Write($"{match} ");
            }
        }
    }
}
