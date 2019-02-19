using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RJP.Models.Interfaces;

namespace RJP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieManager _movieManager;

        public MoviesController(IMovieManager movieManager)
        {
            _movieManager = movieManager;
        }

        // GET api/movies
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]UserParams userParams)
        {
            var movies = await _movieManager.GetMovies(userParams.PageNumber, userParams.PageSize, userParams.ResultsLimit, userParams.Genre, userParams.OrderBy);

            Response.AddPagination(movies.CurrentPage, movies.PageSize, movies.TotalCount, movies.TotalPages);

            return Ok(movies);
        }

        // GET api/movies/id
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var movie = await _movieManager.GetMovie(id);

            return Ok(movie);
        }        
    }
}