using System;

namespace ChristmasTourney
{
    class ChristmasTourney
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double moneyRaisedTotal = 0;
            double moneyRaisedDay = 0;
            int winnerCounter = 0;
            int loserCounter = 0;
            int winnerCounterDay = 0;
            int loserCounterDay = 0;

            for (int i = 1; i <= days; i++)
            {

                string input = Console.ReadLine();
                while (input != "Finish")
                {
                    string winLose = Console.ReadLine();
                    if (winLose == "win")
                    {
                        winnerCounterDay++;
                        winnerCounter++;
                        moneyRaisedDay += 20;
                    }
                    else if (winLose == "lose")
                    {
                        loserCounterDay++;
                        loserCounter++;
                    }
                    input = Console.ReadLine();
                }
                if (winnerCounterDay > loserCounterDay)
                {
                    moneyRaisedDay += moneyRaisedDay * 0.10;
                }
                winnerCounterDay = 0;
                loserCounterDay = 0;
                moneyRaisedTotal += moneyRaisedDay;
                moneyRaisedDay = 0;
            }
            if (winnerCounter > loserCounter)
            {
                moneyRaisedTotal += moneyRaisedTotal * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {moneyRaisedTotal:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {moneyRaisedTotal:f2}");
            }

        }
    }
}
