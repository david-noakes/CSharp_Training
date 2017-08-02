using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC_2.Controllers
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

        public ActionResult TestPage()
        {
            ViewBag.PageContent = "Content of Testpage.";
            return View();
        }

        public PartialViewResult GetInfo()
        {
            ViewBag.ItemDEtails = "Twas brillig and the slythy toves <br/>" +
                                  "did gyre and gimbol in the wabe,<br/>" +
                                  "all mimsey were the borogoves <br/>" +
                                  "and the mome raths outgabe";
            return PartialView("_MaryInfo");
        }

        public PartialViewResult GetTestPage()
        {
            ViewBag.Title = "Get Test Page";
            ViewBag.PageContent = "Content of getTestPage.";
            return PartialView("TestPage");
        }
    }
}