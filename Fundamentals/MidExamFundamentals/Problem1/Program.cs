using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            double rivalFactoryBiscuitsMade = double.Parse(Console.ReadLine());

            double totalBiscuitsMade = 0;
            int dayOffCounter = 0;

            for (int i = 0; i < 30; i++)
            {
                dayOffCounter++;
                if (dayOffCounter % 3 == 0)
                {
                    totalBiscuitsMade += workersCount * (biscuitsPerDay * 0.75);
                }
                else
                {
                    totalBiscuitsMade += workersCount * biscuitsPerDay;
                }
                totalBiscuitsMade = Math.Floor(totalBiscuitsMade);
            }
            Console.WriteLine($"You have produced {totalBiscuitsMade} biscuits for the past month.");

            double productionPercent = Math.Abs((totalBiscuitsMade - rivalFactoryBiscuitsMade ) / rivalFactoryBiscuitsMade * 100);
            if (totalBiscuitsMade > rivalFactoryBiscuitsMade)
            {
                Console.WriteLine($"You produce {productionPercent:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {productionPercent:f2} percent less biscuits.");
            }
        }
    }
}
