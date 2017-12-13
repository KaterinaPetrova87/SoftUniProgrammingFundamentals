using System;
using System.Linq;

namespace p05_CompareCharArrays
{
    public class CompareCharArrays
    {
        public static void Main()
        {
            char[] firstArray = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();
            char[] secondArray = Console.ReadLine()
                 .Split()
                 .Select(char.Parse)
                 .ToArray();

            int minLength = Math.Min(firstArray.Length, secondArray.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] <= secondArray[i] && firstArray.Length <= secondArray.Length)
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                    break;
                }
                else
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                    break;
                }
            }
        }
    }
}
