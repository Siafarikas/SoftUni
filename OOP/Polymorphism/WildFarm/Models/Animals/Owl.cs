using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }

        public override void MakeSound()
        {
            string sound = "Hoot Hoot";
            Console.WriteLine(sound);
        }

    }
}
