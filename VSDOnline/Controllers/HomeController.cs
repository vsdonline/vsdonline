using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VSDOnline.Models;
using System.Threading.Tasks;

namespace VSDOnline.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var model = new HomePageViewModel();

            model.siteConfig = db.SiteConfigs.ToList();
            model.UpcomingEvent = db.Events.OrderByDescending(dE => dE.ID).FirstOrDefault();

            if (db.Videos.Count() > 4)
            {
                model.Videos = db.Videos.OrderByDescending(d => d.ID).Take(4).ToList();
            }
            else
            {
                model.Videos = db.Videos.OrderByDescending(d => d.ID).ToList();
            }

            if (db.Photos.Count() > 4)
            {
                model.Photos = db.Photos.OrderByDescending(d => d.ID).Take(4).ToList();
            }
            else
            {
                model.Photos = db.Photos.OrderByDescending(d => d.ID).ToList();
            }

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AboutGuruji()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Services";
            return View();
        }

        public ActionResult Satcharitra()
        {
            ViewBag.Message = "Satcharitra";
            return View();
        }

        public ActionResult Donate()
        {
            ViewBag.Message = "Donate";
            return View();
        }

        public ActionResult Aarthi()
        {
            ViewBag.Message = "Aarthi";
            return View();
        }

        public ActionResult LiveDarshan()
        {
            ViewBag.skipviewport = true;
            ViewBag.Message = "LiveDarshan";
            return View();
        }
        public ActionResult SaiGayatri()
        {
            ViewBag.Message = "SaiGayatri";
            return View();
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