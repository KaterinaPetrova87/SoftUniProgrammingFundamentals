using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPointParts = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                Point currentPoint = new Point
                {
                    X = currentPointParts[0],
                    Y = currentPointParts[1]
                };

                points.Add(currentPoint);
            }

            double minDistance = double.MaxValue;
            Point firstPointMax = null;
            Point secondPointMax = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    Point firstPoint = points[i];
                    Point secondPoint = points[j];

                    double currentDistance = CalculateDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstPointMax = firstPoint;
                        secondPointMax = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({firstPointMax.X}, {firstPointMax.Y})");
            Console.WriteLine($"({secondPointMax.X}, {secondPointMax.Y})");
        }

        static double CalculateDistance(Point first, Point second)
        {
            double diffX = first.X - second.X;
            double diffY = first.Y - second.Y;
            double result = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            return result;
        }

        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}

