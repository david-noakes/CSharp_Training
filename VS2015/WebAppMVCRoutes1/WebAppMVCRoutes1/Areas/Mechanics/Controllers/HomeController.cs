using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVCRoutes1.Areas.Mechanics.Controllers
{
    public class HomeController : Controller
    {
        // GET: Mechanics/Home
        public ActionResult Index()
        {
            var currentAction = RouteData.Values["action"];
            var currentController = RouteData.Values["controller"];
            var area = RouteData.DataTokens["area"];
            if (area == null)
            {
                area = "Main";
            }
            var pageMsg = "Area = " + area + ",Controller = " + currentController + ", Action = " + currentAction;
            ViewBag.Message = pageMsg;
            ViewBag.Area = area;
            ViewBag.Controller = currentController;
            ViewBag.Action = currentAction;

            var redirectFlag = false; // set to true to redirect
            if (redirectFlag)
            {
                return RedirectToAction("Index", "Home", new { area = "Customers" });
            }
            return View();
        }

        // GET: Mechanics/Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mechanics/Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mechanics/Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mechanics/Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mechanics/Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mechanics/Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mechanics/Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
