using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyQuanNuoc.Models;

namespace QuanLyQuanNuoc.Controllers
{
    public class BookedTablesController : Controller
    {
        private CNPM_QLNGKEntities db = new CNPM_QLNGKEntities();

        // GET: BookedTables
        public ActionResult Index()
        {
            return View(db.BookedTables.ToList());
        }

        // GET: BookedTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookedTable bookedTable = db.BookedTables.Find(id);
            if (bookedTable == null)
            {
                return HttpNotFound();
            }
            return View(bookedTable);
        }

        // GET: BookedTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookedTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTable,CustomerName,CustomerPhone,CustomerAddress,BookDate,BookTimeStart,BookTimeEnd")] BookedTable bookedTable)
        {
            if (ModelState.IsValid)
            {
                db.BookedTables.Add(bookedTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookedTable);
        }

        // GET: BookedTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookedTable bookedTable = db.BookedTables.Find(id);
            if (bookedTable == null)
            {
                return HttpNotFound();
            }
            return View(bookedTable);
        }

        // POST: BookedTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTable,CustomerName,CustomerPhone,CustomerAddress,BookDate,BookTimeStart,BookTimeEnd")] BookedTable bookedTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookedTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookedTable);
        }

        // GET: BookedTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookedTable bookedTable = db.BookedTables.Find(id);
            if (bookedTable == null)
            {
                return HttpNotFound();
            }
            return View(bookedTable);
        }

        // POST: BookedTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookedTable bookedTable = db.BookedTables.Find(id);
            db.BookedTables.Remove(bookedTable);
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
