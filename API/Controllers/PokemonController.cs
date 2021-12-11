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
            _context.Pokemons.Add(pokemon);
            await _context.SaveChangesAsync();
            return Ok();
        }

        //GET /api/pokemon
        [HttpGet]
        public async Task<IActionResult> GetAllPokemon()
        {
            return Ok(_context.Pokemons);
        }

        //Get A Pokemon
        //GET /api/pokemon/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOnePokemon(string id)
        {
             try
            {
                var onePokemon = await _context.Pokemons.FindAsync(new Guid(id));

                if (onePokemon is null)
                {
                    return NotFound();
                }

                return Ok(onePokemon);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        //Get all pokemon of specific type
        //GET /api/pokemon/type
        [HttpGet("type/{type}")]
        public async Task<IActionResult> GetAllPokemonByType(string type)
        {
            try
            {
                var allPokemonByType = _context.Pokemons.Where(x => x.Type == type);

                if (allPokemonByType is null)
                {
                    return NotFound();
                }

                return Ok(allPokemonByType);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }


    }
}