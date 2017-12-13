using System;
using System.Linq;

namespace p03_IntersectionOfCircles
{
    public class IntersectionOfCircles
    {
        public static void Main()
        {
            Circle firstCircle = ReadCircle(Console.ReadLine());
            Circle secondCircle = ReadCircle(Console.ReadLine());

            int deltaX = firstCircle.Center.X - secondCircle.Center.X;
            int deltaY = firstCircle.Center.Y - secondCircle.Center.Y;

            double distanceBetweenCenters = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

            if(distanceBetweenCenters <= firstCircle.Radius + secondCircle.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static Circle ReadCircle(string circleProperties)
        {
            var circleProp = circleProperties.Split(' ').Select(int.Parse).ToArray();
            return new Circle
            {
                Center = new Point
                {
                    X = circleProp[0],
                    Y = circleProp[1],
                },

                Radius = circleProp[2]
                
            };
        }

        public class Point
        {
            public int X { get; set; }

            public int Y { get; set; }
        }

        public class Circle
        {
            public Point Center { get; set; }

            public int Radius { get; set; }
        }
    }
}
