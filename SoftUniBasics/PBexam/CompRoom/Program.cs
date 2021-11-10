using System;

namespace CompRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double pricePerPerson = 0;
            double totalPrice = 0;

            switch (month)
            {
                case "march":
                case "april":
                case "may":
                    if (time == "day")
                    {
                        pricePerPerson = 10.50;
                    }
                    else if(time == "night")
                    {
                        pricePerPerson = 8.40;
                    }
                    break; ;
                case "june":
                case "july":
                case "august":
                    if (time == "day")
                    {
                        pricePerPerson = 12.60;
                    }
                    else if (time == "night")
                    {
                        pricePerPerson = 10.20;
                    }
                    break; ;
            }
            if (people >= 4)
            {
                pricePerPerson -= pricePerPerson * 0.10;
            }
            if (hours >= 5)
            {
                pricePerPerson -= pricePerPerson * 0.50;
            }
            totalPrice = pricePerPerson * people * hours;
            Console.WriteLine($"Price per person for one hour: {pricePerPerson:f2}");
            Console.WriteLine($"Total cost of the visit: {totalPrice:f2}");


        }
    }
}
