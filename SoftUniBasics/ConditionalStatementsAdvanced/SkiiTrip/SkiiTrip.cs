using System;

namespace SkiiTrip
{
    class SkiiTrip
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            int nights = days - 1;
            double cost = 0;

            if (room == "room for one person")
            {
                cost = 18.00 * nights;
            }
            else if (room == "apartment")
            {
                if (days <= 10)
                {
                    cost = 25.00 * nights;
                    cost = cost - cost * 0.30;

                }
                else if (days >= 10 && days <= 15)
                {
                    cost = 25.00 * nights;
                    cost = cost - cost * 0.35;
                }
                else if (days >= 15)
                {
                    cost = 25.00 * nights;
                    cost = cost - cost * 0.50;
                }
            }
            else if (room == "president apartment")
            {
                if (days <= 10)
                {
                    cost = 35.00 * nights;
                    cost = cost - cost * 0.10;

                }
                else if (days >= 10 && days <= 15)
                {
                    cost = 35.00 * nights;
                    cost = cost - cost * 0.15;
                }
                else if (days >= 15)
                {
                    cost = 35.00 * nights;
                    cost = cost - cost * 0.20;
                }
            }

            if (rating == "positive")
            {
                cost = cost + cost * 0.25;

            }
            else if (rating == "negative")
            {
                cost = cost - cost * 0.10;
            }
            Console.WriteLine($"{cost:f2}");
        }
    }
}
