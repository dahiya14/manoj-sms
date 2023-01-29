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
    public class NMC_Controller : Controller
    {
        private stsEntities db = new stsEntities();

        // GET: NMC_
        public ActionResult Index()
        {
            return View(db.NMC_.ToList());
        }

        // GET: NMC_/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMC_ nMC_ = db.NMC_.Find(id);
            if (nMC_ == null)
            {
                return HttpNotFound();
            }
            return View(nMC_);
        }

        // GET: NMC_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NMC_/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,REGNO,RANK,NAME,UNIT,THEORY,PRACTICAL,G_TOTAL,PERCENTAGE,GRADE,REMARK,BATCHRANK")] NMC_ nMC_)
        {
            if (ModelState.IsValid)
            {
                db.NMC_.Add(nMC_);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nMC_);
        }

        // GET: NMC_/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMC_ nMC_ = db.NMC_.Find(id);
            if (nMC_ == null)
            {
                return HttpNotFound();
            }
            return View(nMC_);
        }

        // POST: NMC_/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,REGNO,RANK,NAME,UNIT,THEORY,PRACTICAL,G_TOTAL,PERCENTAGE,GRADE,REMARK,BATCHRANK")] NMC_ nMC_)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nMC_).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nMC_);
        }

        // GET: NMC_/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NMC_ nMC_ = db.NMC_.Find(id);
            if (nMC_ == null)
            {
                return HttpNotFound();
            }
            return View(nMC_);
        }

        // POST: NMC_/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NMC_ nMC_ = db.NMC_.Find(id);
            db.NMC_.Remove(nMC_);
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
