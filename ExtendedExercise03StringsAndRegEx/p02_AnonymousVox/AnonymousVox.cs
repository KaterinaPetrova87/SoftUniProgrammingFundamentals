using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p02_AnonymousVox
{
    public class AnonymousVox
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string[] placeholders = Console.ReadLine()
                .Split(new[] { '}', '{' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string pattern = @"([a-zA-Z]+)(.+)\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            int placeholderIndex = 0;

            foreach (Match match in matches)
            {
                if (placeholderIndex > placeholders.Length-1)
                {
                    break;
                }

                string matched = match.Groups[2].Value;
                string replacement = placeholders[placeholderIndex];

                var substrOld = text.Substring(0, text.IndexOf(matched) + matched.Length);
                var substrNew = substrOld.Replace(matched, replacement);

                text = substrNew + text.Substring(substrOld.Length);
                
                placeholderIndex++;
            }

            Console.WriteLine(text);
        }
    }
}
