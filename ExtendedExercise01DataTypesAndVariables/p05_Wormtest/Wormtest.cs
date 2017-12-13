using System;

namespace p05_Wormtest
{
    public class Wormtest
    {
        public static void Main()
        {
            double wormLengthInMeters = double.Parse(Console.ReadLine());
            double wormWidthInCentimeters = double.Parse(Console.ReadLine());
            double percent = 0;

            double wormLengthtInCentimeters = wormLengthInMeters * 100;
            double remainder = wormLengthtInCentimeters % wormWidthInCentimeters;

            if (remainder == 0 || wormWidthInCentimeters == 0)
            {
                percent = wormLengthtInCentimeters * wormWidthInCentimeters;
                Console.WriteLine($"{percent:F2}");
            }
            else
            {
                percent = (wormLengthtInCentimeters / wormWidthInCentimeters) * 100;
                Console.WriteLine($"{percent:F2}%");
            }
        }
    }
}
