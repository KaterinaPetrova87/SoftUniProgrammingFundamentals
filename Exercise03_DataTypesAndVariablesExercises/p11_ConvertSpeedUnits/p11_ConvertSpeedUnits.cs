using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_ConvertSpeedUnits
{
    class p11_ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int timeInSeconds = hours * 3600 + minutes * 60 + seconds;
            double timeInHours = hours + (double)minutes / 60 + (double)seconds / 3600;
            float metersPerSecond = (float)distanceInMeters / timeInSeconds;
            float distanceInKm = distanceInMeters / 1000;
            float kilometersPerHour = (float)(distanceInKm / timeInHours);
            float distanceInMiles = (float)distanceInMeters / 1609;
            float milesPerHour = (float)(distanceInMiles / timeInHours);

            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
