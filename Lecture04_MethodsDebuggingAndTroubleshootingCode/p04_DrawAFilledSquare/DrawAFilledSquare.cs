using System;

namespace p04_DrawAFilledSquare
{
    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintFilledSquare(n);
        }

        public static void PrintFilledSquare(int n)
        {
            PrintTopAndBottom(n);
            PrintBody(n);
            PrintTopAndBottom(n);
        }

        public static void PrintBody(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        public static void PrintTopAndBottom(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
