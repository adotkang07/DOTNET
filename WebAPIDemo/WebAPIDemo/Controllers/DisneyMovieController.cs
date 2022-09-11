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
        public async Task<IActionResult> GetMovies()
        {

            return Ok(DisneyMovieService.DisneyMovies);
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
