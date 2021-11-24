using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public void CreateAnimal(string[] data)
        {
            string type = data[0];
            string name = data[1];
            double weight = double.Parse(data[2]);
            
            switch (type)
            {
                case ""
                default:
            }
        }
    }
}
