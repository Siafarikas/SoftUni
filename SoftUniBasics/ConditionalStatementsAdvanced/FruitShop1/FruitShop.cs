using System;

namespace FruitShop1
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double price = 0;
            switch (fruit)
            {
                case "banana":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 2.50;
                            Console.WriteLine($"{amount * price:f2}");
                            break;

                        case "Saturday":
                        case "Sunday":
                            price = 2.70;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "apple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 1.20;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 1.25;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "orange":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 0.85;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 0.90;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapefruit":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 1.45;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 1.60;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "kiwi":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 2.70;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 3.00;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "pineapple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 5.50;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 5.60;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapes":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            price = 3.85;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        case "Saturday":
                        case "Sunday":
                            price = 4.20;
                            Console.WriteLine($"{amount * price:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
