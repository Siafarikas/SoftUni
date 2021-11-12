using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int availableFood = int.Parse(Console.ReadLine());

            int[] clientOrders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(clientOrders);

            while (true)
            {
                if (orders.Count == 0)
                {
                    break;
                }
                if (availableFood - orders.Peek() >= 0)
                {
                    availableFood -= orders.Peek();
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(clientOrders.Max());
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write($"Orders left: ");
                foreach (var order in orders)
                {
                    Console.Write(order + " ");
                }
            }
        }
    }
}
