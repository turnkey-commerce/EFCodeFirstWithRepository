using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models.Repository {
    public class MovieRepository : IMovieRepository {
        private IMovieContext _context;

        public MovieRepository(IMovieContext context)
        {
            _context = context;
        }

        public IQueryable<Movie> FindAll() {
            IQueryable<Movie> movies = _context.Movies;
            return movies;
        }

        public Movie FindById(int id){
            return _context.Movies.Find(id);
        }

        public void Save(Movie movie) {
            if (movie.ID == 0)
                _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(Movie movie) {
            _context.Movies.Remove(movie);
        }


    }
}