using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> clothes = new Stack<int>(input);
            int capacity = int.Parse(Console.ReadLine());
            int racksCount = 1;
            int sumRack = 0;

            while (clothes.Count > 0)
            {
                if (sumRack + clothes.Peek() < capacity)
                {
                    sumRack += clothes.Pop();
                }
                else if (sumRack + clothes.Peek() == capacity)
                {
                    clothes.Pop();
                    sumRack = 0;
                    if (clothes.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        racksCount++;
                    }
                }
                else if (sumRack + clothes.Peek() > capacity)
                {
                    sumRack = 0;
                    racksCount++;
                }
            }
            Console.WriteLine(racksCount);
        }
    }
}
