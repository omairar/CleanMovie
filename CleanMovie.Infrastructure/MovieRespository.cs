using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    //1. Microsoft.EntityFrameworkCor
    //2. Microsoft.EntityFrameworkCore.Design
    //2. Microsoft.EntityFrameworkCore.Tools
    //2. Microsoft.EntityFrameworkCore.SqlServer
    public class MovieRespository : IMoviesRespository
    {
       

        CleanMovieContext  _cleanMovieContext;

        public MovieRespository(CleanMovieContext cleanMovieContext)
        {
            _cleanMovieContext  = cleanMovieContext;
        }

        public Movie CreateAmovie(Movie movie)
        {
            _cleanMovieContext.Movies.Add(movie);
            _cleanMovieContext.SaveChanges();

            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _cleanMovieContext.Movies.ToList();
            return movies;
        }
    }
}
