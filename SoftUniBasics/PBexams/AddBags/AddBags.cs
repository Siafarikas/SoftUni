using System;

namespace AddBags
{
    class AddBags
    {
        static void Main(string[] args)
        {
            double priceOver20 = double.Parse(Console.ReadLine());
            double kgsLuggage = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int luggage = int.Parse(Console.ReadLine());
            double costLuggage;

            if (kgsLuggage < 10)
            {
                costLuggage = priceOver20 * 0.20;
            }
            else if (kgsLuggage <= 20)
            {
                costLuggage = priceOver20 * 0.50;
            }
            else
            {
                costLuggage = priceOver20;
            }
            if (days < 7)
            {
                costLuggage = costLuggage + costLuggage * 0.40;
            }
            else if (days <= 30)
            {
                costLuggage = costLuggage + costLuggage * 0.15;
            }
            else
            {
                costLuggage = costLuggage + costLuggage * 0.10;
            }
            Console.WriteLine($"The total price of bags is: {costLuggage * luggage:f2} lv.");
        }
    }
}
