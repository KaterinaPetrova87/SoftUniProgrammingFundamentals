using System;
using System.Linq;

namespace p02_RotateAndSum
{
    public class RotateAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];

            for (int i = 0; i < rotations; i++)
            {
                int[] rotated = new int[numbers.Length];
                rotated[0] = numbers[numbers.Length - 1];
                for (int j = 1; j < rotated.Length; j++)
                {
                    rotated[j] = numbers[j - 1];
                    sum[j] += rotated[j];
                }
                sum[0] += rotated[0];
                numbers = rotated;
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
