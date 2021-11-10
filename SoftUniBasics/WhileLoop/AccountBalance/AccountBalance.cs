using System;

namespace AccountBalance
{
    class AccountBalance
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            while (input != "NoMoreMoney")
            {

               double deposit = double.Parse(input);
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {deposit:f2}");
                sum += deposit;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");

        }
    }
}
