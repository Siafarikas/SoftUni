using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] hero = Console.ReadLine()
                    .Split(" ");
                string heroName = hero[0];
                int hp = int.Parse(hero[1]);
                int mana = int.Parse(hero[2]);
                heroes.Add(heroName, new List<int> { hp, mana });
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] parts = input
                    .Split(" - ");
                string action = parts[0];
                string heroName = parts[1];

                if (action == "CastSpell")
                {
                    int manaCost = int.Parse(parts[2]);
                    string spellName = parts[3];

                    if (manaCost <= heroes[heroName][1])
                    {
                        heroes[heroName][1] -= manaCost;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(parts[2]);
                    string attacker = parts[3];

                    heroes[heroName][0] -= damage;
                    if (heroes[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                    else
                    {
                        heroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (action == "Recharge")
                {
                    int manaRestored = int.Parse(parts[2]);

                    heroes[heroName][1] += manaRestored;

                    if (heroes[heroName][1]> 200)
                    {
                        manaRestored = manaRestored - (heroes[heroName][1] - 200);
                        heroes[heroName][1] = 200;
                    }
                    Console.WriteLine($"{heroName} recharged for {manaRestored} MP!");
                }
                else if (action == "Heal")
                {
                    int hpRestored = int.Parse(parts[2]);

                    heroes[heroName][0] += hpRestored;

                    if (heroes[heroName][0] > 100)
                    {
                        hpRestored = hpRestored - (heroes[heroName][0] - 100);
                        heroes[heroName][0] = 100;
                    }
                    Console.WriteLine($"{heroName} healed for {hpRestored} HP!");
                }
            }
            heroes = heroes
                .OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in heroes)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine($"  HP: {kvp.Value[0]}");
                Console.WriteLine($"  MP: {kvp.Value[1]}");
            }
        }
    }
}
