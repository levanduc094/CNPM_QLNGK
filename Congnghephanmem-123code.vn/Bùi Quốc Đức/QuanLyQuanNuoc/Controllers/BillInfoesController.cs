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
    public class BillInfoesController : Controller
    {
        private CNPM_QLNGKEntities1 db = new CNPM_QLNGKEntities1();

        // GET: BillInfoes
        public ActionResult Index()
        {
            var billInfoes = db.BillInfoes.Include(b => b.Bill).Include(b => b.Drink).Include(b => b.Employee).Include(b => b.Food);
            return View(billInfoes.ToList());
        }

        // GET: BillInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillInfo billInfo = db.BillInfoes.Find(id);
            if (billInfo == null)
            {
                return HttpNotFound();
            }
            return View(billInfo);
        }

        // GET: BillInfoes/Create
        public ActionResult Create()
        {
            ViewBag.idBill = new SelectList(db.Bills, "idBill", "idBill");
            ViewBag.idDrink = new SelectList(db.Drinks, "idDrink", "name");
            ViewBag.idEmp = new SelectList(db.Employees, "idEmp", "name");
            ViewBag.idFood = new SelectList(db.Foods, "idFood", "name");
            
            return View();
        }

        // POST: BillInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idBill,idFood,idDrink,idEmp,countF,countD,totalPrice")] BillInfo billInfo)
        {
            //int id = Convert.ToInt32(billInfo.idBill);
            if (ModelState.IsValid)
            {
                //    var query = from i in db.BillInfoes
                //                join j in db.Drinks on i.idDrink equals j.idDrink
                //                where i.idBill == id
                //                select j.price;

                //    var query1 = from i in db.BillInfoes
                //                 join j in db.Foods on i.idDrink equals j.idFood
                //                 where i.idBill == id
                //                 select j.price;
                //    double q = Convert.ToDouble(query);
                //    double c = Convert.ToDouble(query1);


                //   billInfo.totalPrice =Convert.ToInt32((q * billInfo.countD)+ (c * billInfo.countF));
                db.BillInfoes.Add(billInfo);
            db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idBill = new SelectList(db.Bills, "idBill", "idBill", billInfo.idBill);
            ViewBag.idDrink = new SelectList(db.Drinks, "idDrink", "name", billInfo.idDrink);
            ViewBag.idEmp = new SelectList(db.Employees, "idEmp", "name", billInfo.idEmp);
            ViewBag.idFood = new SelectList(db.Foods, "idFood", "name", billInfo.idFood);
            return View(billInfo);
        }

        // GET: BillInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillInfo billInfo = db.BillInfoes.Find(id);
            if (billInfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.idBill = new SelectList(db.Bills, "idBill", "idBill", billInfo.idBill);
            ViewBag.idDrink = new SelectList(db.Drinks, "idDrink", "name", billInfo.idDrink);
            ViewBag.idEmp = new SelectList(db.Employees, "idEmp", "name", billInfo.idEmp);
            ViewBag.idFood = new SelectList(db.Foods, "idFood", "name", billInfo.idFood);
            return View(billInfo);
        }

        // POST: BillInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idBill,idFood,idDrink,idEmp,countF,countD,totalPrice")] BillInfo billInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(billInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idBill = new SelectList(db.Bills, "idBill", "idBill", billInfo.idBill);
            ViewBag.idDrink = new SelectList(db.Drinks, "idDrink", "name", billInfo.idDrink);
            ViewBag.idEmp = new SelectList(db.Employees, "idEmp", "name", billInfo.idEmp);
            ViewBag.idFood = new SelectList(db.Foods, "idFood", "name", billInfo.idFood);
            return View(billInfo);
        }

        // GET: BillInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillInfo billInfo = db.BillInfoes.Find(id);
            if (billInfo == null)
            {
                return HttpNotFound();
            }
            return View(billInfo);
        }

        // POST: BillInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BillInfo billInfo = db.BillInfoes.Find(id);
            db.BillInfoes.Remove(billInfo);
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
