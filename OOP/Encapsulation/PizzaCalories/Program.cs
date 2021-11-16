using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string pizzaName = Console.ReadLine().Split(" ")[1];
                string[] doughElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Dough dough = new Dough(doughElements[1], doughElements[2], double.Parse(doughElements[3]));
                Pizza pizza = new Pizza(pizzaName);
                pizza.Dough = dough;

                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "END")
                    {
                        break;
                    }
                    string[] toppingElements = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Topping currentTopping = new Topping(toppingElements[1], double.Parse(toppingElements[2]));
                    pizza.AddTopping(currentTopping);
                }
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
