using System;

namespace Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int pieces = int.Parse(Console.ReadLine());
            Order(product, pieces);
        }
        static void Order(string product, int pieces)
        {
            double price = 0;
            if (product == "coffee")
            {
                price = pieces * 1.50;
            }
            else if (product == "water")
            {
                price = pieces * 1.00;
            }
            else if (product == "coke")
            {
                price = pieces * 1.40;
            }
            else if (product == "snacks")
            {
                price = pieces * 2.00;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
