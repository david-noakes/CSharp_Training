﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC.Controllers
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

        public ActionResult NewPage()
        {
            ViewBag.Message = "Your new page that you added.";

            return View();
        }

        public ActionResult NewViewPage()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            var msg = String.Format("Controller: >{0}< Action: >{1}< Id: >{2}<",
                controller, action, id);
            ViewBag.Message = msg;

            return View();
        }

        public ActionResult Alternate()
        {
            ViewBag.Message = "Your new page that you added.";

            return Content("Redirect page.");
        }

        public ActionResult TestPage()
        {
            ViewBag.PageContent = "Content from our test page";

            return View();
        }

    }
}