using System;

namespace p03_UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("\\u{0:x4}", (int)text[i]);
            }
        }
    }
}

