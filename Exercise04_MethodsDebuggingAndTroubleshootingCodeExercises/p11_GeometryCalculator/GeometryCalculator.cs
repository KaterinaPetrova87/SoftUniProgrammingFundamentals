using System;

namespace p11_GeometryCalculator
{
    public class GeometryCalculator
    {
        public static void Main()
        {
            string figure = Console.ReadLine();
            CalculateTheAreaOfFigures(figure);
        }

        static double CalculateTheAreaOfFigures (string figure)
        {
            double area = 0;
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = side * height / 2;
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = width * height;
            }
            else
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            Console.WriteLine($"{area:F2}");
            return area;
        }
    }
}
