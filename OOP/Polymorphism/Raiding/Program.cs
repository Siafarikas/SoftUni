using System;
using Raiding.Core;
using Raiding.Factories;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            IHeroFactory heroFactory = new HeroFactory();
            IEngine engine = new Engine(heroFactory);
            engine.Run();
        }
    }
}
