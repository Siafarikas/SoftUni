using System;

namespace Journey
{
    class Journey
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string typeHoliday = "";
            double price = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price = budget * 0.30;
                    typeHoliday = "Camp";
                }
                else if (season == "winter")
                {
                    price = budget * 0.70;
                    typeHoliday = "Hotel";
                }

            }

            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price = budget * 0.40;
                    typeHoliday = "Camp";
                }
                else if (season == "winter")
                {
                    price = budget * 0.80;
                    typeHoliday = "Hotel";
                }
            }

            else if (budget >= 1000)
            {
                destination = "Europe";
                typeHoliday = "Hotel";
                price = budget * 0.90;

            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeHoliday} - {price:f2}");
        }
    }
}
