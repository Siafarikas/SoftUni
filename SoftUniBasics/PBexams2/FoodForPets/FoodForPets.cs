using System;

namespace FoodForPets
{
    class FoodForPets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double totalFoodConsumed = 0;
            double dogFoodTotal = 0;
            double catFoodTotal = 0;
            double biscuits = 0;

            for (int i = 1; i <= days; i++)
            {
                double DailyConsumedDog = int.Parse(Console.ReadLine());
                double DailyConsumedCat = int.Parse(Console.ReadLine());
                totalFoodConsumed += DailyConsumedCat + DailyConsumedDog;
                dogFoodTotal += DailyConsumedDog;
                catFoodTotal += DailyConsumedCat;
                if (i % 3 == 0)
                {
                    biscuits += (DailyConsumedCat + DailyConsumedDog) * 0.10;
                }

            }
            double percentTotalFood = (dogFoodTotal + catFoodTotal) / totalFood * 100;
            double percentDog = (dogFoodTotal / totalFoodConsumed) * 100;
            double percentCat = (catFoodTotal / totalFoodConsumed) * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{percentTotalFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentCat:f2}% eaten from the cat.");
        }
    }
}
