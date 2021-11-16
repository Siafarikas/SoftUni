using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            for (int i = 0; i < firstLine.Length; i++)
            {
                string[] info = firstLine[i].Split('=');
                try
                {
                    var currentPerson = new Person(info[0], decimal.Parse(info[1]));
                    people.Add(currentPerson);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            string[] secondLine = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Product> allProducts = new List<Product>();
            for (int i = 0; i < secondLine.Length; i++)
            {
                string[] info = secondLine[i].Split('=');
                try
                {
                    var currentProduct = new Product(info[0], decimal.Parse(info[1]));
                    allProducts.Add(currentProduct);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = info[0];
                string productName = info[1];
                var currentPerson = people.Find(x => x.Name == personName);
                var currentProduct = allProducts.Find(x => x.Name == productName);
                if (currentPerson.Money >= currentProduct.Cost)
                {
                    Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    currentPerson.BagOfProducts.Add(currentProduct);
                    currentPerson.Money -= currentProduct.Cost;
                }
                else
                {
                    Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                }
            }

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].BagOfProducts.Count > 0)
                {
                    Console.WriteLine($"{people[i].Name} - {string.Join(", ", people[i].BagOfProducts.Select(x => x.Name).ToArray())}");

                }
                else
                {
                    Console.WriteLine($"{people[i].Name} - Nothing bought ");
                }
            }


        }
    }
}
