using System;

namespace GoldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locationsCount = int.Parse(Console.ReadLine());
            double goldExpected = 0;
            double goldMined = 0;

            for (int i = 1; i <= locationsCount; i++)
            {
                goldExpected = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                for (int j = 1; j <= days; j++)
                {
                    goldMined += double.Parse(Console.ReadLine());
                }
                if (goldMined / days >= goldExpected)
                {
                    Console.WriteLine($"Good job! Average gold per day: {goldMined / days:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {goldExpected - goldMined / days:f2} gold.");
                }
                goldMined = 0;
            }
        }
    }
}
