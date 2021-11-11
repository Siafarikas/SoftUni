using System;

namespace RageExpanses
{
    class RageExpanses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            int trashedH = 0;
            int trashedM = 0;
            int trashedK = 0;
            int trashedD = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    trashedH++;
                }
                if (i % 3 == 0)
                {
                    trashedM++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedK++;
                    if (trashedK % 2 == 0 && trashedK != 0)
                    {
                        trashedD++;
                    }
                }

            }
            double totalPrice = trashedH * headset + trashedM * mouse + trashedK * keyboard + trashedD * display;
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
