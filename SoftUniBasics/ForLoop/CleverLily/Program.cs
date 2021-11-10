using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceCleaner = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());

            double savings = 0;
            int gift = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    savings += priceToys;
                }
                else if (i % 2 == 0)
                {
                    gift += 10;
                    savings += gift;
                    savings -= 1;
                }
            }
            if (savings >= priceCleaner)
            {
                Console.WriteLine($"Yes! {savings - priceCleaner:f2}");
            }
            else if (savings < priceCleaner)
            {
                Console.WriteLine($"No! {priceCleaner - savings:f2}");
            }

        }
    }
}
