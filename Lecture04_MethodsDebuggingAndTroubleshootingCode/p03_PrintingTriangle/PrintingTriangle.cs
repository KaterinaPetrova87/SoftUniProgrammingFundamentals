using System;

namespace p03_PrintingTriangle
{
    public class PrintingTriangle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        public static void PrintColumns(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }

        public static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintColumns(row);
            }

            for (int row = n - 1; row >= 1; row--)
            {
                PrintColumns(row);
            }
        }
    }
}
