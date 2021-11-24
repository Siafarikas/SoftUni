using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        private int power = 100;

        public Paladin(string name)
            : base(name)
        {

        }

        public override int Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }


        public override string CastAbility()
        {
            return $"Paladin - {Name} healed for {Power}";
        }
    }
}
