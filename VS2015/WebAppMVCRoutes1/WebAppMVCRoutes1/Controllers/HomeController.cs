using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVCRoutes1.Controllers
{
    [Authorize(Users ="david@b.c, danny@b.c")]
    public class HomeController : Controller
    {
        // GET: Home
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
            return View();
        }

        [OverrideAuthorization]
        [Authorize(Users = "danny@b.c")]
        // GET: Home
        public ActionResult About()
        {
            return View();
        }

        // GET: Home
        public ActionResult Contact()
        {
            var currentAction = RouteData.Values["action"];
            var currentController = RouteData.Values["controller"];
            var pageMsg = "Controller = " + currentController + " Action = " + currentAction;
            ViewBag.Message = pageMsg;
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
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

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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
