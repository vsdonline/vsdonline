﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VSDOnline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
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


    }
}