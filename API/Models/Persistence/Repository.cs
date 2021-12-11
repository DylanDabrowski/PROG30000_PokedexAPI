using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models.Entities;

namespace API.Models.Persistence
{
    public static class Repository
    {
        private static List<Pokemon> _pokemons;

        static Repository()
        {
            _pokemons = new List<Pokemon>();
        }

        public static void AddPokemon(Pokemon pokemon)
        {
            _pokemons.Add(pokemon);
        }

        public static IEnumerable<Pokemon> Pokemons => _pokemons;
        
    }
}