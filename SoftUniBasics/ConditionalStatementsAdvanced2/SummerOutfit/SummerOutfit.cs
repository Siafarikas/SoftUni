using System;

namespace SummerOutfit
{
    class SummerOutfit
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string Outfit = "";
            string Shoes = "";

            if (temp >= 10 && temp <= 18)
            {
                if (time == "Morning")
                {
                    Outfit = "Sweatshirt";
                    Shoes = "Sneakers";
                }
                else if (time == "Afternoon")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (time == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            else if (temp > 18 && temp <= 24)
            {
                if (time == "Morning")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (time == "Afternoon")
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
                else if (time == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            else if (temp >= 25)
            {
                if (time == "Morning")
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
                else if (time == "Afternoon")
                {
                    Outfit = "Swim Suit";
                    Shoes = "Barefoot";
                }
                else if (time == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {temp} degrees, get your {Outfit} and {Shoes}.");
        }
    }
}
