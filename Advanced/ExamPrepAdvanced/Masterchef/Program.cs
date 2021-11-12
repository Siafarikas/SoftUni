using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x > 0));

            var freshness = new Stack<int>(Console.ReadLine()
                 .Split()
                 .Select(int.Parse));

            int dippingsauce = 0;
            int greenSalad = 0;
            int chocolateCake = 0;
            int lobster = 0;

            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                int freshnessLvl = ingredients.Peek() * freshness.Peek();
                switch (freshnessLvl)
                {
                    case 150:
                        ingredients.Dequeue();
                        freshness.Pop();
                        dippingsauce++;
                        break;
                    case 250:
                        ingredients.Dequeue();
                        freshness.Pop();
                        greenSalad++;
                        break;
                    case 300:
                        ingredients.Dequeue();
                        freshness.Pop();
                        chocolateCake++;
                        break;
                    case 400:
                        ingredients.Dequeue();
                        freshness.Pop();
                        lobster++;
                        break;
                    default:
                        freshness.Pop();
                        ingredients.Enqueue(ingredients.Dequeue() + 5);
                        break;
                }
            }
            if (dippingsauce > 0 && greenSalad > 0 && chocolateCake > 0 && lobster > 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($" # Chocolate cake --> {chocolateCake}");
                Console.WriteLine($" # Dipping sauce --> {dippingsauce}");
                Console.WriteLine($" # Green salad --> {greenSalad}");
                Console.WriteLine($" # Lobster --> {lobster}");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if (ingredients.Count > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
                if (chocolateCake > 0)
                {
                    Console.WriteLine($" # Chocolate cake --> {chocolateCake}");

                }
                if (dippingsauce > 0)
                {
                    Console.WriteLine($" # Dipping sauce --> {dippingsauce}");

                }
                if (greenSalad > 0)
                {
                    Console.WriteLine($" # Green salad --> {greenSalad}");

                }
                if (lobster > 0)
                {
                    Console.WriteLine($" # Lobster --> {lobster}");

                }
            }

        }
    }
}
