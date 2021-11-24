using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Feline : Mammal
    {
        public string Breed { get; set; }
        public Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

    }
}
