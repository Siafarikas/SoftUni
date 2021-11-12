using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Func<string, int, bool> checker = (name, n) =>
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }

                if (sum >= n)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<Func<string, int, bool>, List<string>, string> triFunction = (checker, names) =>
            {
                foreach (var name in names)
                {
                    if (checker(name, n))
                    {
                        return name;
                    }
                }
                return "no such name";
            };
            Console.WriteLine(triFunction(checker, names));
        }
    }
}
