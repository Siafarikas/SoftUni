using System;

namespace EnergyBooster
{
    class EnergyBooster
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int orders = int.Parse(Console.ReadLine());
            double cost = 0;

            switch (fruit)
            {
                case "Watermelon":
                    if (size == "small")
                    {
                        cost = orders * 2 * 56;
                    }
                    else if (size == "big")
                    {
                        cost = orders * 5 * 28.70;
                    }
                    break;
                case "Mango":
                    if (size == "small")
                    {
                        cost = orders * 2 * 36.66;
                    }
                    else if (size == "big")
                    {
                        cost = orders * 5 * 19.60;
                    }
                    break;
                case "Pineapple":
                    if (size == "small")
                    {
                        cost = orders * 2 * 42.10;
                    }
                    else if (size == "big")
                    {
                        cost = orders * 5 * 24.80;
                    }
                    break;
                case "Raspberry":
                    if (size == "small")
                    {
                        cost = orders * 2 * 20;
                    }
                    else if (size == "big")
                    {
                        cost = orders * 5 * 15.20;
                    }
                    break;
            }
            if (cost >= 400 && cost <= 1000)
            {
                cost = cost - cost * 0.15;
            }
            else if (cost > 1000)
            {
                cost = cost - cost * 0.50;
            }
            Console.WriteLine($"{cost:f2} lv.");
        }
    }
}
