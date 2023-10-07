using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public ActionResult<List<Movie>> getAllMovies()
        {
            var moviesfromServie = _movieService.GetAllMovies();

            return Ok(moviesfromServie);
        }
        [HttpPost]
        public ActionResult<Movie> Post(Movie movie)
        {
            var moviesfromServie = _movieService.CreateAmovie(movie);

            return Ok(movie);
        }
    }
}
