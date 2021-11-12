using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Tournament")
                {
                    break;
                }

                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (!trainers.Any(x => x.Name == info[0]))
                {
                    Trainer currTrainer = new Trainer(info[0], new List<Pokemon>());
                    currTrainer.AddPokemonToTeam(info[1], info[2], int.Parse(info[3]));
                    trainers.Add(currTrainer);

                }
                else
                {
                    Trainer currTrainer = trainers.Find(x => x.Name == info[0]);
                    currTrainer.AddPokemonToTeam(info[1], info[2], int.Parse(info[3]));
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                switch (input)
                {
                    case "Fire":
                        GetBadgeLoseHealth(trainers, input);
                        break;

                    case "Water":
                        GetBadgeLoseHealth(trainers, input);
                        break;

                    case "Electricity":
                        GetBadgeLoseHealth(trainers, input);
                        break;
                }
            }
            trainers = trainers
                .OrderByDescending(x => x.Badges)
                .ToList();

            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static void GetBadgeLoseHealth(List<Trainer> trainers, string element)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(x => x.Element == element))
                {
                    trainer.Badges++;
                }
                else
                {
                    trainer.Pokemons.ForEach(x => x.Health -= 10);
                    trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                }

            }
        }
    }
}
