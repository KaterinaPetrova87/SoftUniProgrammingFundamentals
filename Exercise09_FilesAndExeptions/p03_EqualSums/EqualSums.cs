using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p03_EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            string[] tests = File.ReadAllLines("../../input.txt");
            string[] result = new string[tests.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = $"{EqualSum(tests[i].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray())}";
            }

            File.WriteAllLines("../../output.txt", result);
        }

        private static string EqualSum(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return 0.ToString();
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int leftSum = numbers.Take(i).Sum();
                int rightSum = 0;
                for (int j = numbers.Length - 1; j > i; j--)
                {
                    rightSum += numbers[j];
                    if (leftSum == rightSum)
                    {
                        return i.ToString();
                    }
                }
            }

            return "no";
        }
    }
}
