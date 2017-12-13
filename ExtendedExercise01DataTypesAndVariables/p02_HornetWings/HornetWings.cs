using System;

namespace p02_HornetWings
{
    public class HornetWings
    {
        public static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double metersTraveled = (wingFlaps / 1000) * distance;

            int flapsInSec = wingFlaps / 100;
            double restsInSec = (wingFlaps / endurance) * 5;
            double secondsPassed = flapsInSec + restsInSec;

            Console.WriteLine($"{metersTraveled:F2} m.");
            Console.WriteLine($"{secondsPassed} s.");
        }
    }
}
