using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplejoBorjaNathan.Controllers
{
    [Authorize(Roles ="Administrador")]
    public class PublicacionesController : Controller
    {
        // GET: Publicaciones
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: Publicaciones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Publicaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Publicaciones/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Publicaciones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Publicaciones/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Publicaciones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Publicaciones/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
