using System;

namespace AluminumJoinery
{
    class AluminumJoinery
    {
        static void Main(string[] args)
        {
            int dograma = int.Parse(Console.ReadLine());
            string dogramaType = Console.ReadLine();
            string delivery = Console.ReadLine();
            double price = 0;

            if (dograma < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            else
            {
                switch (dogramaType)
                {
                    case "90X130":
                        if (dograma < 30)
                        {
                            price = 110;
                        }
                        else if (dograma < 60)
                        {
                            price = 110;
                            price = price - price * 0.05;
                        }
                        else
                        {
                            price = 110;
                            price = price - price * 0.08;

                        }
                        break;
                    case "100X150":
                        if (dograma < 40)
                        {
                            price = 140;
                        }
                        else if (dograma < 80)
                        {
                            price = 140;
                            price = price - price * 0.06;
                        }
                        else
                        {
                            price = 140;
                            price = price - price * 0.10;
                        }
                        break;
                    case "130X180":
                        if (dograma < 20)
                        {
                            price = 190;
                        }
                        else if (dograma < 50)
                        {
                            price = 190;
                            price = price - price * 0.07;
                        }
                        else
                        {
                            price = 190;
                            price = price - price * 0.12;
                        }
                        break;
                    case "200X300":
                        if (dograma < 25)
                        {
                            price = 250;
                        }
                        else if (dograma < 50)
                        {
                            price = 250;
                            price = price - price * 0.09;
                        }
                        else
                        {
                            price = 250;
                            price = price - price * 0.14;
                        }
                        break;
                }
            }
            double cost = dograma * price;
            if (delivery == "With delivery")
            {
                cost += 60;
            }
            if (dograma > 99)
            {
                cost = cost - cost * 0.04;
            }
            Console.WriteLine($"{cost:f2} BGN");

        }
    }
}
