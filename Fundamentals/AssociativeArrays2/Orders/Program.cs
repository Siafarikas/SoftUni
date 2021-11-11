using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> priceByProduct = new Dictionary<string, decimal>();
            Dictionary<string, int> quantityByProduct = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }

                string[] parts = input.Split();

                string product = parts[0];
                decimal price = decimal.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);

                if (priceByProduct.ContainsKey(product))
                {
                    quantityByProduct[product] += quantity;
                    priceByProduct[product] = price;
                }
                else
                {
                    priceByProduct.Add(product, price);
                    quantityByProduct.Add(product, quantity);
                }
            }

            foreach (var item in priceByProduct)
            {
                string product = item.Key;
                decimal price = item.Value;
                int quantity = quantityByProduct[product];

                decimal totalPrice = quantity * price;

                Console.WriteLine($"{product} -> {totalPrice:f2}");
            }
        }
    }
}
