using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models.Repository {
    public class ActorRepository : IActorRepository {
        private IMovieContext _context;

        public ActorRepository(IMovieContext context)
        {
            _context = context;
        }

        public IQueryable<Actor> FindAll() {
            IQueryable<Actor> actors = _context.Actors;
            return actors;
        }

        public Actor FindById(int id){
            return _context.Actors.Find(id);
        }

        public void Save(Actor actor) {
            if (actor.ID == 0)
                _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(Actor actor) {
            _context.Actors.Remove(actor);
        }


    }
}