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
        private DataContext _context;

        public PokemonController(DataContext context)
        {
            _context = context;
        }

        //POST /api/pokemon
        // adds 1 pokemon to db
        [HttpPost]
        public async Task<IActionResult> AddPokemon([FromBody] Pokemon pokemon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _context.Pokemons.AddAsync(pokemon);
            await _context.SaveChangesAsync();
            return Ok();
        }

        //POST /api/pokemon/addmany
        // adds list of pokemon to db
        [HttpPost("addmany")]
        public async Task<IActionResult> AddManyPokemon([FromBody] Pokemon[] pokemon)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.Pokemons.AddRangeAsync(pokemon);
            await _context.SaveChangesAsync();
            return Ok();
        }

        //GET /api/pokemon/unsorted
        // gets all pokemon from db
        [HttpGet("unsorted")]
        public async Task<IActionResult> GetAllPokemon()
        {
            return Ok(_context.Pokemons);
        }

        //GET /api/pokemon
        // gets all pokemon from db sorted by "Number"
        [HttpGet]
        public async Task<IActionResult> GetAllPokemonSorted()
        {
            return Ok(_context.Pokemons.OrderBy(x => x.Number));
        }

        //GET /api/pokemon/{id}
        // gets 1 pokemon from db by id
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

        //GET /api/pokemon/bytype/{type}
        // gets list of pokemon from db by type
        [HttpGet("bytype/{type}")]
        public async Task<IActionResult> GetAllPokemonByType(string type)
        {
            try
            {
                var allPokemonByType = _context.Pokemons.Where(x => x.Type == type);

                if (allPokemonByType is null)
                {
                    return NotFound(allPokemonByType);
                }

                return Ok(allPokemonByType);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        //GET /api/pokemon/{name}
        // gets list of pokemon from db by name
        [HttpGet("byname/{name}")]
        public async Task<IActionResult> GetAllPokemonByName(string name)
        {
            try
            {
                var allPokemonByName = _context.Pokemons.Where(x => x.Name == name);

                if (allPokemonByName is null)
                {
                    return NotFound(allPokemonByName);
                }

                return Ok(allPokemonByName);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        //DELETE /api/pokemon/{id}
        // deletes 1 pokemon from db by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePokemon(string id)
        {
            try
            {
                var onePokemon = await _context.Pokemons.FindAsync(new Guid(id));

                if (onePokemon is null)
                {
                    return NotFound();
                }
                _context.Pokemons.Remove(onePokemon);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        //DELETE /api/pokemon/deleteall
        // deletes 1 pokemon from db by id
        [HttpDelete("deleteall")]
        public async Task<IActionResult> DeleteAllPokemon()
        {
            try
            {
                _context.Pokemons.RemoveRange(_context.Pokemons);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }


    }
}