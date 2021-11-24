using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }

        public override void MakeSound()
        {
            string sound = "Cluck";
            Console.WriteLine(sound);
        }
    }
}
