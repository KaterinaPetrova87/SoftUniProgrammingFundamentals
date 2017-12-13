using System;

namespace p11_DebugPriceChangeAlert
{
    public class DebugPriceChangeAlert
    {
        public static void Main()
        {
            int numOfPrices = int.Parse(Console.ReadLine());
            double significanceThreshold = double.Parse(Console.ReadLine());
            double previousPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = CalculateDifference(previousPrice, currentPrice);
                bool isSignificantDifference = IsDifferenceSignificant(difference, significanceThreshold);
                string message = GetMessage(currentPrice, previousPrice, difference, isSignificantDifference);

                Console.WriteLine(message);

                previousPrice = currentPrice;
            }
        }

        static string GetMessage(double currentPrice, double previousPrice, double difference, bool isSignificantDifference)
        {
            string message = "";
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference < 0))
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
            return message;
        }

        static bool IsDifferenceSignificant(double significanceThreshold, double isDiff)
        {
            if (Math.Abs(significanceThreshold) >= isDiff)
            {
                return true;
            }
            return false;
        }

        static double CalculateDifference(double previousPrice, double currentPrice)
        {
            double difference = (currentPrice - previousPrice) / previousPrice;
            return difference;
        }
    }
}
