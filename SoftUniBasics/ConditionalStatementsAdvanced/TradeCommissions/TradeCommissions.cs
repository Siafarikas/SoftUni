using System;

namespace TradeCommissions
{
    class TradeCommissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;
            if (sales <= 500 && sales >= 0)
            {
                if (town == "Sofia")
                {
                    commission = 0.05;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else if (town == "Varna")
                {
                    commission = 0.045;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else if (town == "Plovdiv")
                {
                    commission = 0.055;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sales <= 1000 && sales >= 500)
            {
                if (town == "Sofia")
                {
                    commission = 0.07;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else if (town == "Varna")
                {
                    commission = 0.075;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else if (town == "Plovdiv")
                {
                    commission = 0.08;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sales <= 10000 && sales >= 1000)
            {
                if (town == "Sofia")
                {
                    commission = 0.08;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else if (town == "Varna")
                {
                    commission = 0.10;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else if (town == "Plovdiv")
                {
                    commission = 0.12;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sales >= 10000)
            {
                if (town == "Sofia")
                {
                    commission = 0.12;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else if (town == "Varna")
                {
                    commission = 0.13;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else if (town == "Plovdiv")
                {
                    commission = 0.145;
                    Console.WriteLine($"{sales * commission:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sales < 0)
            {
                Console.WriteLine("error");
            }

        }
    }
}
