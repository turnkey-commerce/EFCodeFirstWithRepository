using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcMovieTest.Fakes;
using MvcMovie.Models;

namespace MvcMovieTest {
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class MovieRepositoryTest {

        [TestMethod()]
        public void GetMoviesTest() {
            FakeMovieRepository repository = new FakeMovieRepository(new FakeMovieContext()); 

            List<Movie> expected = new List<Movie>();
            expected.Add(new Movie { ID = 1, Title = "Test Album 1", Genre = "Genre 1", Price = 8.99M, Rating = "R", ReleaseDate = new DateTime(1985, 6, 1) });
            expected.Add(new Movie { ID = 2, Title = "Test Album 2", Genre = "Genre 2", Price = 8.99M, Rating = "R", ReleaseDate = new DateTime(1985, 6, 1) });
            expected.Add(new Movie { ID = 3, Title = "Test Album 1", Genre = "Genre 3", Price = 8.99M, Rating = "R", ReleaseDate = new DateTime(1999, 6, 1) });

            List<Movie> actual = repository.FindAll().ToList();
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
