using System;

namespace DivideWithoutRemainder
{
    class DivideWithoutRemainder
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            double numsp1 = 0;
            double numsp2 = 0;
            double numsp3 = 0;

            for (int i = 1; i <= nums; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    numsp1++;
                }
                if (currentNumber % 3 == 0)
                {
                    numsp2++;
                }
                if (currentNumber % 4 == 0)
                {
                    numsp3++;
                }
            }
            double p1 = (numsp1 / nums) * 100;
            double p2 = (numsp2 / nums) * 100;
            double p3 = (numsp3 / nums) * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
