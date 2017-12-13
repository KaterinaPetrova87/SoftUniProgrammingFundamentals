using System;

namespace p10_CubeProperties
{
    public class CubeProperties
    {
        public static void Main()
        {
            double sideOfTheCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            CalculatesParametersOfCube(sideOfTheCube, parameter);
        }

        static void CalculatesParametersOfCube(double side, string parameter)
        {
            double result = 0;
            if (parameter == "face")
            {
                result = Math.Sqrt(2 * Math.Pow(side, 2)); 
            }
            else if (parameter == "space")
            {
                result = Math.Sqrt(3 * Math.Pow(side, 2));
            }
            else if (parameter == "volume")
            {
                result = Math.Pow(side, 3);
            }
            else
            {
                result = 6 * Math.Pow(side, 2);
            }
            Console.WriteLine($"{result:F2}");
        }
    }
}
