using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCModelBinding1.Models;

namespace MVCModelBinding1.Controllers
{
    public class ProductLocalController : Controller
    {
        // GET: ProductLocal
        public ActionResult Index()
        {
            return View();
        }

        // POST: ProductLocal
        [HttpPost]
        public ActionResult Index(
            [ModelBinder(typeof(ProductCustomBinder))] ProductLocal myProduct)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ProdName = myProduct.ProductName;
                ViewBag.ProdDesc = myProduct.ProductDescription;
            }
            return View();
        }

        // GET: ProductLocal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductLocal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductLocal/Create
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

        // GET: ProductLocal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductLocal/Edit/5
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

        // GET: ProductLocal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductLocal/Delete/5
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
