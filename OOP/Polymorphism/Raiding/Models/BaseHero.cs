using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero : IHero
    {
        public string Name { get; set; }

        public abstract int Power { get; set; }

        public abstract string CastAbility();

        public BaseHero(string name)
        {
            Name = name;
        }
    }
}
