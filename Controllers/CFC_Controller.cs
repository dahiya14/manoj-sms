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
    public class CFC_Controller : Controller
    {
        private stsEntities db = new stsEntities();

        // GET: CFC_
        public ActionResult Index()
        {
            return View(db.CFC_.ToList());
        }

        // GET: CFC_/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CFC_ cFC_ = db.CFC_.Find(id);
            if (cFC_ == null)
            {
                return HttpNotFound();
            }
            return View(cFC_);
        }

        // GET: CFC_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CFC_/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,REGNO,RANK,NAME,UNIT,THEORY,PRACTICAL,G_TOTAL,PERCENTAGE,GRADE,REMARK,BATCHRANK")] CFC_ cFC_)
        {
            if (ModelState.IsValid)
            {
                db.CFC_.Add(cFC_);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cFC_);
        }

        // GET: CFC_/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CFC_ cFC_ = db.CFC_.Find(id);
            if (cFC_ == null)
            {
                return HttpNotFound();
            }
            return View(cFC_);
        }

        // POST: CFC_/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,REGNO,RANK,NAME,UNIT,THEORY,PRACTICAL,G_TOTAL,PERCENTAGE,GRADE,REMARK,BATCHRANK")] CFC_ cFC_)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cFC_).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cFC_);
        }

        // GET: CFC_/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CFC_ cFC_ = db.CFC_.Find(id);
            if (cFC_ == null)
            {
                return HttpNotFound();
            }
            return View(cFC_);
        }

        // POST: CFC_/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CFC_ cFC_ = db.CFC_.Find(id);
            db.CFC_.Remove(cFC_);
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
