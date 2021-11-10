using System;

namespace SuitcasesLoad
{
    class SuitcasesLoad
    {
        static void Main(string[] args)
        {
            double space = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double totalBags = 0;
            double fullSpace = 0;

            while (input != "End")
            {
                double bag = double.Parse(input);
                if (totalBags % 2 == 0)
                {
                    bag += bag * 0.10;
                }
                fullSpace += bag;
                if (fullSpace >= space)
                {
                    Console.WriteLine("No more space!");
                    break;
                }
                input = Console.ReadLine();
                totalBags++;
            }
            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {totalBags} suitcases loaded.");
        }
    }
}
