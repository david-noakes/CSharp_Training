using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace WebApplMVC_3.Controllers
{
    // cache the entire controller
    [OutputCache(Duration = 15,
        VaryByParam = "none"  )]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Current time is: " + DateTime.Now.ToString("T");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Current time is: " + DateTime.Now.ToString("T");

            return View();
        }

        //[OutputCache(Duration = 15,
        //    Location = OutputCacheLocation.Any,
        //    VaryByCustom = "browser",
        //    VaryByParam = "none"
        //    )]

        public ActionResult Contact()
        {
            ViewBag.Message = "Current time is: " + DateTime.Now.ToString("T");

            return View();
        }
    }
}