using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public Animal(string name, double weight)
        {
            Weight = weight;
            Name = name;
        }

        public virtual void MakeSound()
        {
            string sound = null;
            Console.WriteLine(sound);
        }

    }
}
