using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API.Models.Persistence
{
    public class IndexModel : PageModel
    {
        public DataContext Context { get; }
        public IndexModel(DataContext _context)
        {
            this.Context = _context;
        }

        public List<Pokemon> Pokemons { get; set; }

        public void OnGet()
        {
            this.Pokemons = Context.Pokemons.ToList();
        }
    }
}