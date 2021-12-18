using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities
{
    public class PokemonEvolution
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }


    }
}