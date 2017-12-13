using System;
using System.Text.RegularExpressions;

namespace p01_ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            string pattern = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]{1,}([-.]\w*)*(\.[a-z]{1,})";

            var regex = new Regex(pattern);
            string textToMatch = Console.ReadLine();

            var contains = regex.Matches(textToMatch);

            foreach (Match mail in contains)
            {
                Console.WriteLine(mail);
            }
        }
    }
}
