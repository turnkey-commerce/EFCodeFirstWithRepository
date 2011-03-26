using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcMovie.Models.Repository {
    public interface IMovieRepository {

        IQueryable<Movie> FindAll();

        Movie FindById(int ID);

        void Save(Movie movie);

        void Delete(Movie movie);
    }
}
