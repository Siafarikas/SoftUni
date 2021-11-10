using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodBought = 1000 * int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double totalFoodEaten = 0;

            while (input != "Adopted")
            {
                double foodEaten = double.Parse(input);
                totalFoodEaten += foodEaten;
                if (totalFoodEaten > foodBought)
                {
                }
                input = Console.ReadLine();
            }
            if (totalFoodEaten > foodBought)
            {
                Console.WriteLine($"Food is not enough. You need {totalFoodEaten - foodBought} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodBought - totalFoodEaten} grams.");
            }

        }
    }
}
