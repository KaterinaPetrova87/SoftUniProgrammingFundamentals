using System;

namespace p03_TextFilter
{
    public class TextFilter
    {
        public static void Main()
        {
            string[] badWords = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var badWord in badWords)
            {
                text = text.Replace(badWord, new string('*', badWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
