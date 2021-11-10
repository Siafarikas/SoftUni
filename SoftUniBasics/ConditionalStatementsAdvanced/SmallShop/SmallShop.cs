using System;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double price = 0;

            switch (product)
            {
                case "coffee":
                    switch (town)
                    {
                        case "Sofia":
                            price = 0.50;

                            break;
                        case "Plovdiv":
                            price = 0.40;

                            break;
                        case "Varna":
                            price = 0.45;
                            break;

                        default:
                            break;
                    }
                    break;

                case "water":
                    switch (town)
                    {
                        case "Sofia":
                            price = 0.80;

                            break;
                        case "Plovdiv":
                            price = 0.70;

                            break;
                        case "Varna":
                            price = 0.70;

                            break;

                        default:
                            break;
                    }

                    break;

                case "beer":
                    switch (town)
                    {
                        case "Sofia":
                            price = 1.20;

                            break;
                        case "Plovdiv":
                            price = 1.15;

                            break;
                        case "Varna":
                            price = 1.10;

                            break;

                        default:
                            break;
                    }

                    break;

                case "sweets":
                    switch (town)
                    {
                        case "Sofia":
                            price = 1.45;

                            break;
                        case "Plovdiv":
                            price = 1.30;

                            break;
                        case "Varna":
                            price = 1.35;

                            break;

                        default:
                            break;
                    }

                    break;

                case "peanuts":
                    switch (town)
                    {
                        case "Sofia":
                            price = 1.60;

                            break;
                        case "Plovdiv":
                            price = 1.50;

                            break;
                        case "Varna":
                            price = 1.55;

                            break;

                        default:
                            break;
                    }

                    break;

                default:
                    break;


            }

            Console.WriteLine(amount * price);
        }
    }
}
