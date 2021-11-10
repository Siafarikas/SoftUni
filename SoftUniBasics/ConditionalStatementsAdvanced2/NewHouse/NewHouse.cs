using System;

namespace NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0;

            if (flower == "Roses")
            {
                price = amount * 5.00;

                if (amount > 80)
                {
                    price = price - price * 0.10;
                }
            }
            else if (flower == "Dahlias")
            {
                price = amount * 3.80;

                if (amount > 90)
                {
                    price = price - price * 0.15;
                }
            }
            else if (flower == "Tulips")
            {
                price = amount * 2.80;

                if (amount > 80)
                {
                    price = price - price * 0.15;
                }
            }
            else if (flower == "Narcissus")
            {
                price = amount * 3.00;

                if (amount < 120)
                {
                    price = price + price * 0.15;
                }
            }
            else if (flower == "Gladiolus")
            {
                price = amount * 2.50;

                if (amount < 80)
                {
                    price = price + price * 0.20;
                }
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {amount} {flower} and {budget - price:f2} leva left.");
            }
            else if (budget <= price)
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}
