using System;

namespace p03_EnglishNameOfLastDigit
{
    public class EnglishNameOfLastDigit
    {
        public static void Main()
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));

            Console.WriteLine(ReturnNumberToString(number));
        }

        static string ReturnNumberToString(long number)
        {
            number = number % 10;
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "";
            }
        }
    }
}
