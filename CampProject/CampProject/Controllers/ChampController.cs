using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampProject.Controllers
{
    public class ChampController : Controller
    {
        // GET: Champ
        public ActionResult Index()
        {
            return View();
        }

        // GET: Champ/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Champ/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Champ/Create
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

        // GET: Champ/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Champ/Edit/5
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

        // GET: Champ/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Champ/Delete/5
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
