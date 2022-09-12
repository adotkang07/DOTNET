using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;
using WebAPIDemo.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisneyMovieController : ControllerBase
    {
      
        // GET api/<CustomersController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(DisneyMovieService.DisneyMovies);
        }

        // GET api/<CustomersController>/id
        [HttpGet("id")]
        public async Task<IActionResult> Get(int id)
        {
            var movie = DisneyMovieService.DisneyMovies.Where(x => x.Id == id);
            return Ok(movie);
        }
            
        // POST api/<CustomersController>
        [HttpPost]
        public async Task<IActionResult> AddMovie(DisneyMovieModel disneyMovie)
        {
            DisneyMovieService.DisneyMovies.Add(disneyMovie);
            return Ok(DisneyMovieService.DisneyMovies);
        }

    }
}
