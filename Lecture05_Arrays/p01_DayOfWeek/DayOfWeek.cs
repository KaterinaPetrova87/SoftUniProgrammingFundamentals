using System;

namespace p01_DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(dayOfWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
