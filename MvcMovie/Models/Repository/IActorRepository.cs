using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcMovie.Models.Repository {
    public interface IActorRepository {

        IQueryable<Actor> FindAll();

        Actor FindById(int ID);

        void Save(Actor actor);

        void Delete(Actor actor);
    }
}
