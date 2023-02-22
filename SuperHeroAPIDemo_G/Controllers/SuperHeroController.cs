using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPIDemo_G.Models;

namespace SuperHeroAPIDemo_G.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero
            {
                Id = 1,
                Name = "Spiderman",
                FirstName = "Peter",
                SurName="Parker",
                City="New York"}
        };


        // READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL //
        // READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL //
        // READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL //
        // READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL -  READ ALL //
        [HttpGet]
        //[HttpGet("GetAll")]
        public async Task<ActionResult<List<SuperHero>>> GetAll()
        {
            return Ok(heroes);
        }


        // READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE //
        // READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE //
        // READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE //
        // READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE - READ ONE //
        [HttpGet]
        [Route("{id:int}")]
        //[Route("GetOne/{id:int}")]
        public async Task<ActionResult<SuperHero>> GetOne(int id)
        {
            var hero = heroes
                .Where(s => s.Id == id)
                .Select(s => new SuperHero
                {
                    Id = s.Id,
                    Name = s.Name,
                    FirstName = s.FirstName,
                    SurName = s.SurName,
                    City= s.City
                });

            if (hero == null)
            {
                return NotFound("Superhero not found");
            }
            return Ok(hero);
        }
    }
}
