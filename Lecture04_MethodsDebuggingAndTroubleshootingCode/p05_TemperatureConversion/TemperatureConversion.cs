using System;

namespace p05_TemperatureConversion
{
    public class TemperatureConversion
    {
        public static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = ConvertFahrenheitToCelsius(fahrenheit);

            Console.WriteLine($"{celsius:F2}");
        }

        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
