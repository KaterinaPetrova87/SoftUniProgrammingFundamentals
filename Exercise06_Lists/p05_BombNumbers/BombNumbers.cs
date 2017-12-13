using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_BombNumbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToList();
            List<int> bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bombNumber = bomb[0];
            int bombPower = bomb[1];

            while (numbers.Contains(bombNumber))
            {
                int indexOfBomb = numbers.IndexOf(bombNumber);
                int startIndex = indexOfBomb - bombPower;
                int endIndex = indexOfBomb + bombPower;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex > numbers.Count - 1)
                {
                    endIndex = numbers.Count - 1;
                }
                numbers.RemoveRange(startIndex, endIndex - startIndex + 1);
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
