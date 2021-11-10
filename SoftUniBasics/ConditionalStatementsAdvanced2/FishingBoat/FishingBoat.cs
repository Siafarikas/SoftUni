using System;

namespace FishingBoat
{
    class FishingBoat
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring")
            {
                price = 3000;
                if (fishers <= 6)
                {
                    price = price - price * 0.10;
                }
                else if (fishers >= 7 && fishers <= 11)
                {
                    price = price - price * 0.15;
                }
                else if (fishers >= 12)
                {
                    price = price - price * 0.25;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
                if (fishers <= 6)
                {
                    price = price - price * 0.10;
                }
                else if (fishers >= 7 && fishers <= 11)
                {
                    price = price - price * 0.15;
                }
                else if (fishers >= 12)
                {
                    price = price - price * 0.25;
                }
            }
            else if (season == "Winter")
            {
                price = 2600;
                if (fishers <= 6)
                {
                    price = price - price * 0.10;
                }
                else if (fishers >= 7 && fishers <= 11)
                {
                    price = price - price * 0.15;
                }
                else if (fishers >= 12)
                {
                    price = price - price * 0.25;
                }
            }
            if (fishers % 2 ==0 && (season == "Spring" || season == "Summer" || season == "Winter"))
            {
                price = price - price * 0.05;
            }
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget-price:f2} leva left.");
            }
            else if (budget < price)
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }

        }
    }
}
