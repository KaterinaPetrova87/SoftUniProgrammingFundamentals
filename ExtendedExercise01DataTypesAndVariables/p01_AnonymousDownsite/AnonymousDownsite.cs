using System;
using System.Numerics;

namespace p01_AnonymousDownsite
{
    public class AnonymousDownsite
    {
        public static void Main()
        {
            int numOfWebsites = int.Parse(Console.ReadLine());
            long securityKey = long.Parse(Console.ReadLine());
            decimal totalLoss = 0;

            for (int i = 0; i < numOfWebsites; i++)
            {
                string[] websites = Console.ReadLine().Split();
                string siteName = websites[0];
                long siteVisits = long.Parse(websites[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(websites[2]);

                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;
                totalLoss += siteLoss;

                Console.WriteLine(siteName);
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");

            BigInteger securityToken = BigInteger.Pow(securityKey, numOfWebsites);
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
