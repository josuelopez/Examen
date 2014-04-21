using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_Allan_sibaja___Josue_Lopez.Models;

namespace Examen_Allan_sibaja___Josue_Lopez.Controllers
{
    public class PeliculaController : Controller
    {
        private ContextPelicula db = new ContextPelicula();

        //
        // GET: /Pelicula/

        public ActionResult Index()
        {
            return View(db.infoBlog.ToList());
        }

        //
        // GET: /Pelicula/Details/5

        public ActionResult Details(int id = 0)
        {
            Pelicula pelicula = db.infoBlog.Find(id);
            if (pelicula == null)
            {
                return HttpNotFound();
            }
            return View(pelicula);
        }

        //
        // GET: /Pelicula/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pelicula/Create

        [HttpPost]
        public ActionResult Create(Pelicula pelicula)
        {
            if (ModelState.IsValid)
            {
                db.infoBlog.Add(pelicula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pelicula);
        }

        //
        // GET: /Pelicula/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Pelicula pelicula = db.infoBlog.Find(id);
            if (pelicula == null)
            {
                return HttpNotFound();
            }
            return View(pelicula);
        }

        //
        // POST: /Pelicula/Edit/5

        [HttpPost]
        public ActionResult Edit(Pelicula pelicula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pelicula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pelicula);
        }

        //
        // GET: /Pelicula/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Pelicula pelicula = db.infoBlog.Find(id);
            if (pelicula == null)
            {
                return HttpNotFound();
            }
            return View(pelicula);
        }

        //
        // POST: /Pelicula/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Pelicula pelicula = db.infoBlog.Find(id);
            db.infoBlog.Remove(pelicula);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult Rentada(int id)
        {
            Pelicula pelicula = db.infoBlog.Find(id);
            if (pelicula == null)
            {
                return HttpNotFound();
            }
            return View(pelicula);
        }
    }
}