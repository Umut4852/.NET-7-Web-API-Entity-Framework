using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroApiDotNet7.Models;
using SuperHeroApiDotNet7.Services.SuperHeroServices;

namespace SuperHeroApiDotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
           return await _superHeroService.GetAllHeros();
        }

        [HttpGet("id")]
        public async Task<ActionResult<List<SuperHero>>> GetHero(int id)
        {
            var resul =await _superHeroService.GetHero(id);
            if (resul is null)
                return NotFound();
            return Ok(resul);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            var resul =await _superHeroService.AddHero(hero);
            return Ok(resul);
        }

        [HttpPut("id")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero request)
        {
            var resul =await _superHeroService.UpdateHero(id,request);
            if (resul is null)
                return NotFound();
            return Ok(resul);
        }
        [HttpDelete("id")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var resul =await _superHeroService.DeleteHero(id);
            if (resul is null) 
                return NotFound();
            return Ok(resul);
        }
    }
}

