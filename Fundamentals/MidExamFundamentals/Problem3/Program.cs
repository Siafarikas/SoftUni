using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> originalCards = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> myDeck = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Ready")
                {
                    break;
                }
                string[] parts = input
                    .Split(" ");
                string command = parts[0];
                string card = parts[1];

                if (command == "Add")
                {
                    if (originalCards.Contains(card))
                    {
                        myDeck.Add(card);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(parts[2]);

                    if (originalCards.Contains(card) && index >= 0 && index < myDeck.Count)
                    {
                        myDeck.Insert(index, card);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                }
                else if (command == "Remove")
                {
                    if (myDeck.Contains(card))
                    {
                        myDeck.Remove(card);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command == "Swap")
                {
                    string card2 = parts[2];
                    int index1 = myDeck.IndexOf(card);
                    int index2 = myDeck.IndexOf(card2);
                    myDeck[index1] = card2;
                    myDeck[index2] = card;
                }
                else if (input == "Shuffle deck")
                {
                    myDeck.Reverse();
                }
            }
            Console.WriteLine(String.Join(" ", myDeck));
        }
    }
}
