using System;
using MvcMovie;
using MvcMovie.Models.Repository;
using MvcMovie.Models;
using System.Data.Entity;

namespace MvcMovieTest.Fakes {
    class FakeMovieContext : DbContext, IMovieContext {
        private IDbSet<Movie> _movies;

        public IDbSet<Movie> Movies {
            get {
                this.CreateMovies();
                return this._movies;
            }

            set {
            }
        
        }

        private void CreateMovies() {
            if (_movies == null) {
                _movies = new FakeDbSet<Movie>();
                _movies.Add(new Movie { ID = 1, Title = "Test Album 1", Genre="Genre 1", Price=8.99M, Rating="R", ReleaseDate=new DateTime(1985, 6, 1)});
                _movies.Add(new Movie { ID = 2, Title = "Test Album 2", Genre = "Genre 2", Price = 8.99M, Rating = "R", ReleaseDate = new DateTime(1985, 6, 1) });
                _movies.Add(new Movie { ID = 3, Title = "Test Album 1", Genre = "Genre 3", Price = 8.99M, Rating = "R", ReleaseDate = new DateTime(1999, 6, 1) });
            }
        }

        public int SaveChanges() {
            throw new NotImplementedException();
        }
    }
}
