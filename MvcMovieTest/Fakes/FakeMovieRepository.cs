using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcMovie.Models.Repository;
using MvcMovie.Models;

namespace MvcMovieTest.Fakes {
    class FakeMovieRepository : IMovieRepository {

        private IMovieContext _context;

        public FakeMovieRepository(IMovieContext context)
        {
            _context = context;
        }
       
        public IQueryable<Movie> FindAll() {
            return _context.Movies.AsQueryable<Movie>();
        }

        public Movie FindById(int ID) {
            throw new NotImplementedException();
        }

        public void Save(Movie movie) {
            throw new NotImplementedException();
        }

        public void Delete(Movie movie) {
            throw new NotImplementedException();
        }
    }
}
