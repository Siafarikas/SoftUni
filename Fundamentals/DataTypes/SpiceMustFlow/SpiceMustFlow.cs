using System;

namespace SpiceMustFlow
{
    class SpiceMustFlow
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int extractedSpice = 0;

            if (yield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }
            while (yield >= 100)
            {
                days++;
                extractedSpice += yield - 26;
                yield -= 10;
            }
            extractedSpice -= 26;

            Console.WriteLine(days);
            Console.WriteLine(extractedSpice);
        }
    }
}
