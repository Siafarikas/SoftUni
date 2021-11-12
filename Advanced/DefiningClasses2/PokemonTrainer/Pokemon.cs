using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }

        public Pokemon(string pokemonName, string pokemonType, int pokemonHealth)
        {
            Name = pokemonName;
            Element = pokemonType;
            Health = pokemonHealth;
        }
    }
}
