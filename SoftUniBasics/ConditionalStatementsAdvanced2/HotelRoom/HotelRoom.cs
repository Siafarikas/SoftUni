using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceSt = 0;
            double priceAp = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceSt = nights * 50;
                    priceAp = nights * 65;
                    if (nights > 7 && nights <= 14)
                    {
                        priceSt = priceSt - priceSt * 0.05;
                    }
                    else if (nights > 14)
                    {
                        priceSt = priceSt - priceSt * 0.30;
                    }
                    break;

                case "June":
                case "September":
                    priceSt = nights * 75.20;
                    priceAp = nights * 68.70;
                    if (nights > 14)
                    {
                        priceSt = priceSt - priceSt * 0.20;
                    }

                    break;

                case "July":
                case "August":
                    priceSt = nights * 76;
                    priceAp = nights * 77;
                    break;

                default:
                    break;

            }
            if (nights > 14)
            {
                priceAp = priceAp - priceAp * 0.10;
            }

            Console.WriteLine($"Apartment: {priceAp:f2} lv.");
            Console.WriteLine($"Studio: {priceSt:f2} lv.");
        }
    }
}
