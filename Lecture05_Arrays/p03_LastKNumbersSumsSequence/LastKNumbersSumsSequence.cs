using System;

namespace p03_LastKNumbersSumsSequence
{
    public class LastKNumbersSumsSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];
            numbers[0] = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = Math.Max(0, i - k); j < i; j++)
                {
                    numbers[i] += numbers[j];
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
