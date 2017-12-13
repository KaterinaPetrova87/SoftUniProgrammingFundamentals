using System;
using System.Globalization;

namespace p01_CountWorkingDays
{
    public class CountWorkingDays
    {
        public static void Main()
        {
            string startDateAsText = Console.ReadLine();
            string endDateAsText = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(startDateAsText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endDateAsText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingDays = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday
                    && i.DayOfWeek != DayOfWeek.Sunday
                    && !(i.Month == 1 && i.Day == 1)
                    && !(i.Month == 3 && i.Day == 3)
                    && !(i.Month == 5 && i.Day == 1)
                    && !(i.Month == 5 && i.Day == 6)
                    && !(i.Month == 5 && i.Day == 24)
                    && !(i.Month == 9 && i.Day == 6)
                    && !(i.Month == 9 && i.Day == 22)
                    && !(i.Month == 11 && i.Day == 1)
                    && !(i.Month == 12 && i.Day == 24)
                    && !(i.Month == 12 && i.Day == 25)
                    && !(i.Month == 12 && i.Day == 26))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
