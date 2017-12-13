using System;

namespace p02_CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int index = input.IndexOf(pattern);
            int counter = 0;

            while (index != -1)
            {
                counter++;
                index = input.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
