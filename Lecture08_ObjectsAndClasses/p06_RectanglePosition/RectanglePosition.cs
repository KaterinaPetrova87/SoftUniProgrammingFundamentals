using System;
using System.Linq;

namespace p06_RectanglePosition
{
    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangleParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstRectangle = new Rectangle
            {
                Left = firstRectangleParameters[0],
                Top = firstRectangleParameters[1],
                Width = firstRectangleParameters[2],
                Height = firstRectangleParameters[3]
            };

            var secondRectangleParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondRectangle = new Rectangle
            {
                Left = secondRectangleParameters[0],
                Top = secondRectangleParameters[1],
                Width = secondRectangleParameters[2],
                Height = secondRectangleParameters[3]
            };

            if(IsInside(firstRectangle, secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static bool IsInside(Rectangle first, Rectangle second)
        {
            if (first.Left >= second.Left && first.Right <= second.Right && first.Top <= second.Top && first.Bottom <= second.Bottom)
            {
                return true;
            }
            else
            {
            return false;
            }      
        }

        public class Rectangle
        {
            public int Top { get; set; }

            public int Left { get; set; }

            public int Width { get; set; }

            public int Height { get; set; }

            public int Bottom => Top + Height;

            public int Area => Width * Height;

            public int Right => Left + Width;
        }
    }
}
