using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Models.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {


         private readonly DataContext _context;
    
       
        public HomeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {          
            return View(_context.Pokemons);
            
        }
    }
}