using System;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            double numsp1 = 0;
            double numsp2 = 0;
            double numsp3 = 0;
            double numsp4 = 0;
            double numsp5 = 0;
            for (int i = 1; i <= nums; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < 200)
                {
                    numsp1++;
                }
                else if (currentNumber < 400)
                {
                    numsp2++;
                }
                else if (currentNumber < 600)
                {
                    numsp3++;
                }
                else if (currentNumber < 800)
                {
                    numsp4++;
                }
                else if (currentNumber >= 800)
                {
                    numsp5++;
                }
            }
            double p1 = (numsp1 / nums) * 100;
            double p2 = (numsp2 / nums) * 100;
            double p3 = (numsp3 / nums) * 100;
            double p4 = (numsp4 / nums) * 100;
            double p5 = (numsp5 / nums) * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
