using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; } = 0;
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            Pokemons = pokemons;
        }

        public void AddPokemonToTeam(string pokemonName, string pokemonType, int pokemonHealth)
        {
            Pokemons.Add(new Pokemon(pokemonName, pokemonType, pokemonHealth));
        }
    }
}
