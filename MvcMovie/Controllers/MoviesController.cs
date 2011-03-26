using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;
using System.Linq;
using System.Data.Entity.Infrastructure;
using MvcMovie.Models.Repository;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private IMovieRepository _repository;

        public MoviesController(IMovieRepository repository)
        {
            _repository = repository;
        }

        //
        // GET: /Movies/

        public ActionResult Index()
        {
            var movies = _repository.FindAll().Where(x => x.ReleaseDate > new DateTime(1985, 6, 1));
            return View(movies.ToList());
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie newMovie) {
            if (ModelState.IsValid) {
                _repository.Save(newMovie);
                return RedirectToAction("Index");
            } else {
                return View(newMovie);
            }
        }

        // 
        // GET: /Movies/Details 
        public ActionResult Details(int id) {
            Movie movie = _repository.FindById(id);
            if (movie == null)
                return RedirectToAction("Index");
            return View("Details", movie);
        }

        // GET: /Movies/Edit 

        public ActionResult Edit(int id) {
            Movie movie = _repository.FindById(id);
            if (movie == null)
                return RedirectToAction("Index");

            return View(movie);
        }

        // 
        // POST: /Movies/Edit 

        [HttpPost]
        public ActionResult Edit(Movie model) {
            try {
                Movie movie = _repository.FindById(model.ID);
                UpdateModel(movie);
                _repository.Save(movie);
                return RedirectToAction("Details", new { id = model.ID });
            } catch (Exception) {
                ModelState.AddModelError("", "Edit Failure, see inner exception");
            }

            return View(model);
        }

        // 
        // GET: /Movies/Delete

        public ActionResult Delete(int id) {
            Movie movie = _repository.FindById(id);
            if (movie == null)
                return RedirectToAction("Index");
            return View(movie);
        }

        // 
        // POST: /Movies/Delete 

        [HttpPost]
        public RedirectToRouteResult Delete(int id, FormCollection collection) {
            Movie movie = _repository.FindById(id);
            _repository.Delete(movie);

            return RedirectToAction("Index");
        }

    }
}
