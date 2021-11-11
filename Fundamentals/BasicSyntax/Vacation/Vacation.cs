using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (day == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 8.45;
                }
                else if (typeOfGroup == "Business")
                {
                    price = 10.90;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 15;
                }
            }
            else if (day == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 9.80;
                }
                else if (typeOfGroup == "Business")
                {
                    price = 15.60;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 20;
                }
            }
            else if (day == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 10.46;
                }
                else if (typeOfGroup == "Business")
                {
                    price = 16;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = 22.50;
                }
            }
            double totalPrice = people * price;
            if (typeOfGroup == "Students" && people >= 30)
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }
            else if (typeOfGroup == "Business" && people >= 100)
            {
                totalPrice = totalPrice - 10 * price;
            }
            else if (typeOfGroup == "Regular" && people >= 10 && people <= 20)
            {
                totalPrice = totalPrice - totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
