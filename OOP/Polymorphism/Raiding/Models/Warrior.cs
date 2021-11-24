using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        private int power = 100;
        public Warrior(string name)
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
            return $"Warrior - {Name} hit for {Power} damage";
        }
    }
}
