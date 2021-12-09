using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities
{
    public class Pokemon
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        // Stats
        public int Height { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Weight { get; set; }

        public int test;
    }
}