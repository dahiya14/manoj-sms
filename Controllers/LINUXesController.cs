using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using freshproject1.Models;

namespace freshproject1.Controllers
{
    [Authorize(Roles = "Admin,Instructor")]
    public class LINUXesController : Controller
    {
       
        private stsEntities db = new stsEntities();
        
        // GET: LINUXes
        public ActionResult Index()
        {
            return View(db.LINUXes.ToList());
        }

        // GET: LINUXes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LINUX lINUX = db.LINUXes.Find(id);
            if (lINUX == null)
            {
                return HttpNotFound();
            }
            return View(lINUX);
        }
        [Authorize(Roles ="Admin")]
        // GET: LINUXes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LINUXes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,REGNO,RANK,NAME,UNIT,THEORY,PRACTICAL,G_TOTAL,GRADING,REMARKS,BATCHRANK")] LINUX lINUX)
        {
            if (ModelState.IsValid)
            {
                db.LINUXes.Add(lINUX);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lINUX);
        }

        // GET: LINUXes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LINUX lINUX = db.LINUXes.Find(id);
            if (lINUX == null)
            {
                return HttpNotFound();
            }
            return View(lINUX);
        }

        // POST: LINUXes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,REGNO,RANK,NAME,UNIT,THEORY,PRACTICAL,G_TOTAL,GRADING,REMARKS,BATCHRANK")] LINUX lINUX)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lINUX).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lINUX);
        }

        // GET: LINUXes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LINUX lINUX = db.LINUXes.Find(id);
            if (lINUX == null)
            {
                return HttpNotFound();
            }
            return View(lINUX);
        }

        // POST: LINUXes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LINUX lINUX = db.LINUXes.Find(id);
            db.LINUXes.Remove(lINUX);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
