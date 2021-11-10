using System;

namespace CatWalking
{
    class CatWalking
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int walks = int.Parse(Console.ReadLine());
            int caloriesTaken = int.Parse(Console.ReadLine());
            int caloriesBurned = walks * minutes * 5;

            if (caloriesBurned >= caloriesTaken / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurned}.");
            }
        }
    }
}
