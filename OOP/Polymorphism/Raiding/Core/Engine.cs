using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raiding.Factories;
using Raiding.Models;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly IHeroFactory heroFactory;

        public Engine(IHeroFactory heroFactory)
        {
            this.heroFactory = heroFactory;
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            List<IHero> raidGroup = new List<IHero>();
            while (raidGroup.Count < n)
            {
                string heroName = Console.ReadLine();
                string role = Console.ReadLine();
                if (ValidRole(role))
                {
                    IHero hero = heroFactory.CreateHero(heroName, role);
                    raidGroup.Add(hero);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }
            }
            int bossPower = int.Parse(Console.ReadLine());
            int totalPower = 0;
            for (int i = 0; i < raidGroup.Count; i++)
            {
                IHero currentHero = raidGroup[i];
                Console.WriteLine(currentHero.CastAbility());
                totalPower += currentHero.Power;
            }

            if (totalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private bool ValidRole(string role)
        {
            if (role == "Druid" || role == "Paladin" || role == "Rogue" || role == "Warrior")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
