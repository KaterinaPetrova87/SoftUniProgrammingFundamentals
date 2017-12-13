using System;

namespace p08_CenterPoint
{
    public class CenterPoint
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintTheClosestPointToTheCenter(x1, y1, x2, y2);
        }

        static void PrintTheClosestPointToTheCenter(double x1, double y1, double x2, double y2)
        {
            double firstLine = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double secondLine = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            if (firstLine < secondLine)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
