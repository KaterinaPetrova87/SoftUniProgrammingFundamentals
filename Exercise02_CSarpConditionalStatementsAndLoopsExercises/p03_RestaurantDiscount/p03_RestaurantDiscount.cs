using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03_RestaurantDiscount
{
    class p03_RestaurantDiscount
    {
        static void Main(string[] args)
        {
            double groupSize = double.Parse(Console.ReadLine());
            string typeOfThePackage = Console.ReadLine();
            string hall = "";
            double price = 0;

            if (typeOfThePackage == "Normal")
            {
                if (groupSize <= 50)
                {
                    hall = "Small Hall";
                    price = 3000 - 3000 * 0.05;
                }
                else if (groupSize > 50 && groupSize <= 100)
                {
                    hall = "Terrace";
                    price = 5500 - 5500 * 0.05;
                }
                else if (groupSize > 100 && groupSize <= 120)
                {
                    hall = "Great Hall";
                    price = 8000 - 8000 * 0.05;
                }
            }
            else if (typeOfThePackage == "Gold")
            {
                if (groupSize <= 50)
                {
                    hall = "Small Hall";
                    price = 3250 - 3250 * 0.10;
                }
                else if (groupSize > 50 && groupSize <= 100)
                {
                    hall = "Terrace";
                    price = 5750 - 5750 * 0.10;
                }
                else if (groupSize > 100 && groupSize <= 120)
                {
                    hall = "Great Hall";
                    price = 8250 - 8250 * 0.10;
                }
            }
            else if (typeOfThePackage == "Platinum")
            {
                if (groupSize <= 50)
                {
                    hall = "Small Hall";
                    price = 3500 - 3500 * 0.15;
                }
                else if (groupSize > 50 && groupSize <= 100)
                {
                    hall = "Terrace";
                    price = 6000 - 6000 * 0.15;
                }
                else if (groupSize > 100 && groupSize <= 120)
                {
                    hall = "Great Hall";
                    price = 8500 - 8500 * 0.15;
                }
            }
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {price/groupSize:F2}$");
            }
        }
    }
}
