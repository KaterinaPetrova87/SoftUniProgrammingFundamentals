using System;

namespace p02_CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int count = 0;
            int index = text.IndexOf(pattern);

            while (index != -1)
            {
                index = text.IndexOf(pattern, index + 1);
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
