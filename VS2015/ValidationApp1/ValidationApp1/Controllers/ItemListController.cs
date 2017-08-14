using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ValidationApp1.Models;

namespace ValidationApp1.Controllers
{
    public class ItemListController : Controller
    {
        private ItemListDB db = new ItemListDB("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ValidationApp1;Integrated Security=True");

        // GET: ItemList
        public ActionResult Index()
        {
            return View(db.ItemLists.ToList());
        }

        // GET: ItemList/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemList itemList = db.ItemLists.Find(id);
            if (itemList == null)
            {
                return HttpNotFound();
            }
            return View(itemList);
        }

        // GET: ItemList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ListItemId,Title,ListItemEntry,CompleteByDate")] ItemList itemList)
        {
            if (ModelState.IsValid)
            {
                db.ItemLists.Add(itemList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemList);
        }

        // GET: ItemList/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemList itemList = db.ItemLists.Find(id);
            if (itemList == null)
            {
                return HttpNotFound();
            }
            return View(itemList);
        }

        // POST: ItemList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ListItemId,Title,ListItemEntry,CompleteByDate")] ItemList itemList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemList);
        }

        // GET: ItemList/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemList itemList = db.ItemLists.Find(id);
            if (itemList == null)
            {
                return HttpNotFound();
            }
            return View(itemList);
        }

        // POST: ItemList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemList itemList = db.ItemLists.Find(id);
            db.ItemLists.Remove(itemList);
            db.SaveChanges();
            return RedirectToAction("Index");
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
