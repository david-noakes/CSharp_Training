using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMvcModel1.Models;

namespace WebAppMvcModel1.Controllers
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

        public ActionResult GetPlayInfo()
        {
            ViewBag.Message = "Displaying model property values in a view";
            ModelInformation someInfo = new ModelInformation();
            someInfo.Title = "The Secret Garden";
            someInfo.Synopsis = "A novel written by Francis Hodgeson";

            return View("ModelInfo", someInfo);
        }
    }
}