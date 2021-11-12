using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var scarves = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            var sets = new List<int>();
            while (scarves.Count > 0 && hats.Count > 0)
            {
                if (hats.Peek() > scarves.Peek())
                {
                    sets.Add(hats.Pop() + scarves.Dequeue());
                }
                else if (scarves.Peek() > hats.Peek())
                {
                    hats.Pop();
                    continue;
                }
                else
                {
                    scarves.Dequeue();
                    hats.Push(hats.Pop() + 1);
                }
            }
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(", ", sets));
        }
    }
}
