﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        SWEEntities db = new SWEEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(db.doctors.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact with us on :";

            return View();
        }
    }
}