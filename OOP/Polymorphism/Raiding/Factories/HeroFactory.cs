using System;
using System.Collections.Generic;
using System.Text;
using Raiding.Models;

namespace Raiding.Factories
{
    public class HeroFactory : IHeroFactory
    {
        public IHero CreateHero(string name, string role)
        {
            IHero hero = null;
            if (role == nameof(Druid))
            {
                hero = new Druid(name);
            }
            else if (role == nameof(Paladin))
            {
                hero = new Paladin(name);
            }
            else if (role == nameof(Rogue))
            {
                hero = new Rogue(name);
            }
            else if (role == nameof(Warrior))
            {
                hero = new Warrior(name);
            }
            return hero;
        }
    }
}
