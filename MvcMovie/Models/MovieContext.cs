using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcMovie.Models;
using MvcMovie.Models.Repository;

namespace MvcMovie.Models {
    public class MovieContext : DbContext, IMovieContext {
        public DbSet<Movie> Movies { get; set; }
        //public DbSet<Actor> Actors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Movie>().Property(p => p.Price).HasPrecision(18, 2);
        }
    }
}