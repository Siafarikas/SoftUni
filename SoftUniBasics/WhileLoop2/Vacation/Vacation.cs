using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());
            string action = "";
            double moneyToday = 0;
            double moneyWallet = moneyHave;
            int days = 0;
            int daysSpendingCounter = 0;

            while (true)
            {
                action = Console.ReadLine();
                moneyToday = double.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    moneyWallet -= moneyToday;
                    if (moneyWallet < moneyToday)
                    {
                        moneyWallet = 0;
                    }
                    days++;
                    daysSpendingCounter++;
                }
                else if (action == "save")
                {
                    moneyWallet += moneyToday;
                    days++;
                    daysSpendingCounter = 0;
                }
                if (daysSpendingCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    break;
                }
                else if (moneyWallet >= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }

        }
    }
}
