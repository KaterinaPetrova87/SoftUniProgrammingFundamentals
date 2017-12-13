using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            List<string> text = Console.ReadLine()
                .ToLower()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Where(t => t.Length < 5)
                .OrderBy(t => t)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", text));
        }
    }
}
