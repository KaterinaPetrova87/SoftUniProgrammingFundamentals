using System;
using System.Collections.Generic;

namespace p07_SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                var currentSaleParts = Console.ReadLine()
                    .Split(' ');

                var currentSale = new Sale

                {
                    Town = currentSaleParts[0],
                    Product = currentSaleParts[1],
                    Price = decimal.Parse(currentSaleParts[2]),
                    Quantity = decimal.Parse(currentSaleParts[3])
                };

                sales.Add(currentSale);
            }

            var result = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }
                result[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }

        public class Sale
        {
            public decimal Price { get; set; }

            public string Town { get; set; }

            public string Product { get; set; }

            public decimal Quantity { get; set; }
        }
    }
}
