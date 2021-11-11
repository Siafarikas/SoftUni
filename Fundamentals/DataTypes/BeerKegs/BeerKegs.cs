using System;

namespace BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKegType = "";
            double biggestKeg = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                string keg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume >= biggestKeg)
                {
                    biggestKeg = volume;
                    biggestKegType = keg;
                }

            }
            Console.WriteLine(biggestKegType);
        }
    }
}
