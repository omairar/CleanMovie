using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        IMoviesRespository _movieRepository;
        public MovieService(IMoviesRespository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateAmovie(Movie movie)
        {
            _movieRepository.CreateAmovie(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var list = _movieRepository.GetAllMovies();

            return list;
        }
    }
}
