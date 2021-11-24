using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        private int power = 80;
        public Druid(string name)
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
            return $"Druid - {Name} healed for {Power}";
        }
    }
}
