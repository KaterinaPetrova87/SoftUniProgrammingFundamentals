using System;
using System.Linq;

namespace p03_TextFilter
{
    public class TextFilter
    {
        public static void Main()
        {
            string[] banWords = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string text = Console.ReadLine();

            foreach (var word in banWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
