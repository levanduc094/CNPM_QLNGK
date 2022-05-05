using QuanLyQuanNuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyQuanNuoc.Controllers
{
    public class HomeController : Controller
    {
        private CNPM_QLNGKEntities db = new CNPM_QLNGKEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account acc)
        {
            var lg = (from item in db.Accounts
                      where item.Username == acc.Username && item.Password == acc.Password
                      select new
                      {
                          item.Username,
                          item.DisplayName
                      }).ToList();
            if (lg.FirstOrDefault() == null)
            {
                acc.LoginError = "Username hoặc Password không đúng";
                return RedirectToAction("Login", "Home");

            }
            else
            {
                Session["Username"] = lg.FirstOrDefault().Username;
                Session["Displayname"] = lg.FirstOrDefault().DisplayName;
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("Login", "Home");
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
    }
}