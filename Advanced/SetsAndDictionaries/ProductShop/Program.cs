using System;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Revision")
                {
                    break;
                }
                string[] parts = input.Split(", ");
                string shopName = parts[0];
                string product = parts[1];
                double price = double.Parse(parts[2]);

                if (shops.ContainsKey(shopName) == false)
                {
                    shops[shopName] = new Dictionary<string, double>();
                }

                shops[shopName].Add(product, price);
            }

            foreach (var kvp in shops)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var productPrice in kvp.Value)
                {
                    Console.WriteLine($"Product: {productPrice.Key}, Price: {productPrice.Value} ");
                }
            }
        }
    }
}
