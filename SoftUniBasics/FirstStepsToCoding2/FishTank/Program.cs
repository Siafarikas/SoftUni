using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtInCm = int.Parse(Console.ReadLine());
            int widthInCm = int.Parse(Console.ReadLine());
            int heightInCm = int.Parse(Console.ReadLine());
            double percentTaken = double.Parse(Console.ReadLine());

            double area = lenghtInCm * widthInCm * heightInCm;
            double waterNeededInLeters = area * 0.001 * (1-percentTaken * 0.01);
            Console.WriteLine(waterNeededInLeters);
            
        }
    }
}
