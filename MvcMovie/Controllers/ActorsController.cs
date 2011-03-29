using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models.Repository;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class ActorsController : Controller
    {
        private IActorRepository _repository;

        public ActorsController(IActorRepository repository) 
        {
            _repository = repository;
        }

        //
        // GET: /Actor/

        public ActionResult Index()
        {
            var actors = _repository.FindAll();
            return View(actors.ToList());
        }

        //
        // GET: /Actor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Actor/Create

        [HttpPost]
        public ActionResult Create(Actor newActor)
        {
            if (ModelState.IsValid) {
                _repository.Save(newActor);
                return RedirectToAction("Index");
            } else {
                return View(newActor);
            }
        }
        
        //
        // GET: /Actor/Edit/5
 
        public ActionResult Edit(int id)
        {
            Actor actor = _repository.FindById(id);
            if (actor == null)
                return RedirectToAction("Index");

            return View(actor);
        }

        //
        // POST: /Actor/Edit/5

        [HttpPost]
        public ActionResult Edit(Actor model)
        {
            try {
                Actor actor = _repository.FindById(model.ID);
                UpdateModel(actor);
                _repository.Save(actor);
                return RedirectToAction("Details", new { id = model.ID });
            } catch (Exception) {
                ModelState.AddModelError("", "Edit Failure, see inner exception");
            }

            return View(model);
        }

    }
}
