using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using API.Models.Entities;
using API.Models.Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly DataContext _context;

        public PokemonController(DataContext context)
        {
            _context = context;
        }

        //POST /api/pokemon
        [HttpPost]
        public async Task<IActionResult> AddPokemon([FromBody] Pokemon pokemon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.Pokemon.Add(pokemon);
            await _context.SaveChangesAsync();
            return Ok();
        }

        //GET /api/pokemon
        [HttpGet]
        public async Task<IActionResult> GetAllPokemon()
        {
            return Ok(_context.Pokemon);
        }

    }
}