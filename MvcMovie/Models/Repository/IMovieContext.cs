using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace MvcMovie.Models.Repository {
    public interface IMovieContext {
        IDbSet<Movie> Movies { get; set; }
        int SaveChanges();
    }
}
