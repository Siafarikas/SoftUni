using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Factories
{
    public interface IAnimalFactory
    {
        public void CreateAnimal(string[] data);
    }
}
