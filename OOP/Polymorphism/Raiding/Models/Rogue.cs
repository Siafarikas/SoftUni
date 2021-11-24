using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{

    public class Rogue : BaseHero
    {
        private int power = 80;
        public Rogue(string name)
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
            return $"Rogue - {Name} hit for {Power} damage";
        }
    }
}
