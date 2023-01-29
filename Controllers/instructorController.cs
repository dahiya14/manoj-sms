using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace freshproject1.Controllers
{
    [Authorize(Roles = "Admin,Instructor")]
    public class instructorController : Controller
    {
        // GET: instructor
        public ActionResult Index()
        {
            return View();
        }

        // GET: instructor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: instructor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: instructor/Create
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

        // GET: instructor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: instructor/Edit/5
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

        // GET: instructor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: instructor/Delete/5
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
