using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VSDOnline.Models;

namespace VSDOnline.Controllers
{
    public class SiteConfigsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SiteConfigs
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Index()
        {
            return View(await db.SiteConfigs.ToListAsync());
        }

        // GET: SiteConfigs/Details/5
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteConfig siteConfig = await db.SiteConfigs.FindAsync(id);
            if (siteConfig == null)
            {
                return HttpNotFound();
            }
            return View(siteConfig);
        }

        // GET: SiteConfigs/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SiteConfigs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Create([Bind(Include = "ID,Name,Value,Description,IsActive")] SiteConfig siteConfig)
        {
            if (ModelState.IsValid)
            {
                db.SiteConfigs.Add(siteConfig);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(siteConfig);
        }

        // GET: SiteConfigs/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteConfig siteConfig = await db.SiteConfigs.FindAsync(id);
            if (siteConfig == null)
            {
                return HttpNotFound();
            }
            return View(siteConfig);
        }

        // POST: SiteConfigs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Name,Value,Description,IsActive")] SiteConfig siteConfig)
        {
            if (ModelState.IsValid)
            {
                db.Entry(siteConfig).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(siteConfig);
        }

        //// GET: SiteConfigs/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    SiteConfig siteConfig = await db.SiteConfigs.FindAsync(id);
        //    if (siteConfig == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(siteConfig);
        //}

        //// POST: SiteConfigs/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //[Authorize(Roles = "Admin")]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    SiteConfig siteConfig = await db.SiteConfigs.FindAsync(id);
        //    db.SiteConfigs.Remove(siteConfig);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

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
