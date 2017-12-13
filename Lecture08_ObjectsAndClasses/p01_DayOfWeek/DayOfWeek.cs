using System;
using System.Globalization;

namespace p01_DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            string date = Console.ReadLine();
            DateTime dayOfWeek = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dayOfWeek.DayOfWeek);
        }
    }
}
