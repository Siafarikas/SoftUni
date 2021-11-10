using System;

namespace FitnessCard
{
    class FitnessCard
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double cost = 0;
            switch (sport)
            {
                case "Gym":
                    if (gender == "m")
                    {
                        cost = 42;
                    }
                    else if (gender == "f")
                    {
                        cost = 35;
                    }
                    break;
                case "Boxing":
                    if (gender == "m")
                    {
                        cost = 41;
                    }
                    else if (gender == "f")
                    {
                        cost = 37;
                    }
                    break;
                case "Yoga":
                    if (gender == "m")
                    {
                        cost = 45;
                    }
                    else if (gender == "f")
                    {
                        cost = 42;
                    }
                    break;
                case "Zumba":
                    if (gender == "m")
                    {
                        cost = 34;
                    }
                    else if (gender == "f")
                    {
                        cost = 31;
                    }
                    break;
                case "Dances":
                    if (gender == "m")
                    {
                        cost = 51;
                    }
                    else if (gender == "f")
                    {
                        cost = 53;
                    }
                    break;
                case "Pilates":
                    if (gender == "m")
                    {
                        cost = 39;
                    }
                    else if (gender == "f")
                    {
                        cost = 37;
                    }
                    break;
            }
            if (age <= 19)
            {
                cost = cost - cost * 0.20;
            }
            if (budget > cost)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${cost - budget:f2} more.");
            }
        }
    }
}
