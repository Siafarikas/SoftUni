using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<IPerson> people = new List<IPerson>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                IPerson person;
                if (info[2].All(char.IsDigit))
                {
                    person = new Citizen(info[0]);
                }
                else
                {
                    person = new Rebel(info[0]);
                }
                people.Add(person);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                if (!people.Any(x=> x.Name == input))
                {
                    continue;
                }
                else
                {
                    people.First(x=> x.Name == input).BuyFood();
                }
            }
            int totalFood = people.Sum(x => x.Food);
            Console.WriteLine(totalFood);
        }
    }
}
