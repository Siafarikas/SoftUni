using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {

        }

        public override void MakeSound()
        {
            string sound = "Woof!";
            Console.WriteLine(sound);
        }
    }

}
