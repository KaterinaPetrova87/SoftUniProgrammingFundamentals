using System;

namespace p04_DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            string[] firstPoints = Console.ReadLine().Split(' ');

            Point first = new Point();
            first.X = double.Parse(firstPoints[0]);
            first.Y = double.Parse(firstPoints[1]);

            string[] secondPoints = Console.ReadLine().Split(' ');

            Point second = new Point();
            second.X = double.Parse(secondPoints[0]);
            second.Y = double.Parse(secondPoints[1]);

            double distance = CalculateDistance(first, second);
            Console.WriteLine($"{distance:F3}");

        }

        public static double CalculateDistance(Point first, Point second)
        {
            double diffX = first.X - second.X;
            double diffY = first.Y - second.Y;
            double result = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            return result;
        }

        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}
