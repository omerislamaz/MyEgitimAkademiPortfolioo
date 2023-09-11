using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademiPortfolioo.Models;


namespace MyEgitimAkademiPortfolioo.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.About.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddFeature()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddFeature(About about)
        {
            db.About.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteFeature(int id)
        {
                var value = db.About.Find(id);
                db.About.Remove(value);
                db.SaveChanges();
                return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = db.About.Find(id);
            return View(value);
        }



        [HttpPost]
        public ActionResult UpdateFeature(About about)
        {
            var value = db.About.Find(about.AboutID);
            value.AboutID = about.AboutID;
            value.NameSurname = about.NameSurname;
            value.Title = about.Title;
            value.Introduction = about.Introduction;
            value.Description = about.Description;
            value.AboutImage = about.AboutImage;
           
            db.SaveChanges();
            return RedirectToAction("Index");
        }





       


    }
}