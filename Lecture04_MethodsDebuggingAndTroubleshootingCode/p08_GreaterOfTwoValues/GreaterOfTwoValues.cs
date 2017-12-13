using System;

namespace p08_GreaterOfTwoValues
{
    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                int result = GetMax(firstNum, secondNum);

                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstLetter = char.Parse(Console.ReadLine());
                char secondLetter = char.Parse(Console.ReadLine());

                char result = GetMax(firstLetter, secondLetter);

                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string firstWord = Console.ReadLine();
                string secondWord = Console.ReadLine();

                string result = GetMax(firstWord, secondWord);

                Console.WriteLine(result);
            }
        }

        public static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum >= secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }

        public static char GetMax(char firstLetter, char secondLetter)
        {
            if (firstLetter >= secondLetter)
            {
                return firstLetter;
            }
            else
            {
                return secondLetter;
            }
        }

        public static string GetMax(string firstWord, string secondWord)
        {
            if (firstWord.CompareTo(secondWord) >= 0)
            {
                return firstWord;
            }
            else
            {
                return secondWord;
            }
        }
    }
}
