using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {

        }

        public override void MakeSound()
        {
            string sound = "ROAR!!!";
            Console.WriteLine(sound);
        }
    }
}
