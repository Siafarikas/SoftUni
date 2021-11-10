using System;

namespace CareOfPuppy
{
    class CareOfPuppy
    {
        static void Main(string[] args)
        {
            int foodBought = 1000 * int.Parse(Console.ReadLine());
            string foodEaten = Console.ReadLine();
            int totalFoodEaten = 0;

            while (foodEaten != "Adopted")
            {
                int foodInGrams = int.Parse(foodEaten);
                totalFoodEaten += foodInGrams;
                foodEaten = Console.ReadLine();
            }
            if (foodBought >= totalFoodEaten)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodBought - totalFoodEaten} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFoodEaten -foodBought} grams more.");
            }
        }
    }
}
