using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        public override void MakeSound()
        {
            string sound = "Squeak";
            Console.WriteLine(sound);
        }
    }
}
