using System;

namespace BestPlayer
{
    class BestPlayer
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            int goals = 0;
            string bestPlayer = " ";

            while (player != "END")
            {
                int currentGoals = int.Parse(Console.ReadLine());
                if (currentGoals > goals)
                {
                    goals = currentGoals;
                    bestPlayer = player;
                }
                if (currentGoals >= 10)
                {
                    break;
                }
                player = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (goals >= 3)
            {
                Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goals} goals.");
            }
        }
    }
}
