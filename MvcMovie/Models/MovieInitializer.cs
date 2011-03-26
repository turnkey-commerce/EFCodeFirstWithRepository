using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Models {
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    namespace MvcMovie.Models {
        public class MovieInitializer :   DropCreateDatabaseIfModelChanges<MovieContext> {
            protected override void Seed(MovieContext context) {

                var actors = new List<Actor>{
                    new Actor{Name = "Gregory Peck"},
                    new Actor{Name = "Harrison Ford"}
                };

                var movies = new List<Movie> { 
 
                 new Movie { Title = "When Harry Met Sally",  
                             ReleaseDate=DateTime.Parse("1989-1-11"),  
                             Genre="Romantic Comedy", 
                             Rating="R", 
                             Price=7.00M,
                             Actors=actors}, 
 
                 new Movie { Title = "Ghostbusters 2",  
                             ReleaseDate=DateTime.Parse("1986-2-23"),  
                             Genre="Comedy", 
                             Rating="R", 
                             Price=9.00M},  
             };

                movies.ForEach(d => context.Movies.Add(d));
            }
        }
    }
}