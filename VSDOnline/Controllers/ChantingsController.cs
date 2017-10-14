using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VSDOnline.Models;

namespace VSDOnline.Controllers
{
    public class ChantingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Chantings
        public ActionResult Index()
        {
            var tot = from a in db.Chantings
                      where a.Approved == false
                      select a;
            return View(tot);
        }


        // GET: Chantings/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chanting chanting = db.Chantings.Find(id);
            if (chanting == null)
            {
                return HttpNotFound();
            }
            return View(chanting);
        }

        // GET: Chantings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chantings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Phone,MantraCount,Email,Address")] Chanting chanting)
        {
            var tot = from a in db.Chantings
                           where a.Approved == true
                           select a;

            int? count = tot.ToList().Sum(y => y.MantraCount);


            if (ModelState.IsValid)
            {
                db.Chantings.Add(chanting);
                db.SaveChanges();

                TempData["AlertMessage"] = "Thank You. Total " + count.ToString();

                ModelState.Clear();

                return View(new Chanting());
                //return RedirectToAction("Index");
            }

            return View(chanting);
        }

        // GET: Chantings/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chanting chanting = db.Chantings.Find(id);
            if (chanting == null)
            {
                return HttpNotFound();
            }
            return View(chanting);
        }

        // POST: Chantings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "ID,Name,Phone,MantraCount,Email,Address,Approved,CreateDate")] Chanting chanting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chanting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chanting);
        }

        // GET: Chantings/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chanting chanting = db.Chantings.Find(id);
            if (chanting == null)
            {
                return HttpNotFound();
            }
            return View(chanting);
        }

        // POST: Chantings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Chanting chanting = db.Chantings.Find(id);
            db.Chantings.Remove(chanting);
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
