using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Factories
{
    public interface IHeroFactory
    {
        IHero CreateHero(string name, string role);
    }
}
