using System;

namespace p02_MaxMethod
{
    public class MaxMethod
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int firstMax = GetMaxNumber(firstNum, secondNum);
            int maxNumber = GetMaxNumber(firstMax, thirdNum);

            Console.WriteLine(maxNumber);
        }

        static int GetMaxNumber(int firstNum, int secondNum)
        {
            if (firstNum >= secondNum)
            {
                return firstNum;
            }
            return secondNum;
        }
    }
}
