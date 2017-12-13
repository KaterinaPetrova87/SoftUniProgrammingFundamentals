using System;

namespace p09_IndexOfLetters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            foreach (char letter in input)
            {
                Console.WriteLine($"{letter} -> {letter - 'a'}");
            }
        }
    }
}
