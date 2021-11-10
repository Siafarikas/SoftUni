using System;

namespace Coins
{
    class Coins
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int coinCounter = 0;
            Math.Round(change, 2);

            while (change != 0)
            {
                while (Math.Round(change, 2) >= 2)
                {
                    change -= 2.00;
                    coinCounter++;
                }
                while (Math.Round(change, 2) >= 1)
                {
                    change -= 1.00;
                    coinCounter++;
                }
                while (Math.Round(change, 2) >= 0.50)
                {
                    change -= 0.5;
                    coinCounter++;
                }
                while (Math.Round(change, 2) >= 0.20)
                {
                    change -= 0.20;
                    coinCounter++;
                }
                while (Math.Round(change, 2) >= 0.10)
                {
                    change -= 0.10;
                    coinCounter++;
                }
                while (Math.Round(change, 2) >= 0.05)
                {
                    change -= 0.05;
                    coinCounter++;
                }
                while (Math.Round(change, 2) >= 0.02)
                {
                    change -= 0.02;
                    coinCounter++;
                }
                while (Math.Round(change, 2) >= 0.01)
                {
                    change -= 0.01;
                    coinCounter++;
                }
                Console.WriteLine(coinCounter);
                break;
            }
        }
    }
}
