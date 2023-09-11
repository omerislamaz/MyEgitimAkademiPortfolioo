using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademiPortfolioo.Models;

namespace MyEgitimAkademiPortfolioo.Controllers
{
    public class CareerController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.Career.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCareer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCareer(Career career)
        {
            db.Career.Add(career);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCareer(int id)
        {
            var value = db.Career.Find(id);
            db.Career.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateCareer(int id)
        {
            var value = db.Career.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCareer(Career career)
        {
            var value = db.Career.Find(career.CareerId);
            value.CareerId = career.CareerId;
            value.CareerName = career.CareerName;
            value.CareerDescription = career.CareerDescription;
            value.CareerWorkTime = career.CareerWorkTime;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}