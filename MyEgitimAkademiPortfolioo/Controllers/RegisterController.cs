using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademiPortfolioo.Models;

namespace MyEgitimAkademiPortfolioo.Controllers
{
    public class RegisterController : Controller
    {

        MyPortfolioDbEntities db = new MyPortfolioDbEntities();


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            db.Admin.Add(admin);
            db.SaveChanges();
            return RedirectToAction("Index", "Login");
            
        }
    }
}