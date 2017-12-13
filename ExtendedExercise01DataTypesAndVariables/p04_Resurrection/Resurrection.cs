using System;

namespace p04_Resurrection
{
    public class Resurrection
    {
        public static void Main()
        {
            int amountOfPhoenixes = int.Parse(Console.ReadLine());
            decimal totalYears = 0;

            for (int i = 0; i < amountOfPhoenixes; i++)
            {
                long totalLength = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long lengthOfTheWing = long.Parse(Console.ReadLine());

                totalYears = (totalLength * totalLength) * (totalWidth + (2 * lengthOfTheWing));

                Console.WriteLine(totalYears);
            }
        }
    }
}
