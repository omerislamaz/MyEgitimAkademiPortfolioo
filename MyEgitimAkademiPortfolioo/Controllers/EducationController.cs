using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademiPortfolioo.Models;

namespace MyEgitimAkademiPortfolioo.Controllers
{
    
    public class EducationController : Controller
    {

        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.Education.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEducation(Education education)
        {
            db.Education.Add(education);
            db.SaveChanges();
            return RedirectToAction("Index");
          
        }

        public ActionResult DeleteEducation(int id)
        {
            var value = db.Education.Find(id);
            db.Education.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = db.Education.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateEducation(Education education)
        {
            var value = db.Education.Find(education.EducationId);
            value.EducationName = education.EducationName;
            value.EducationDescription = education.EducationDescription;
            value.EducationGraduation = education.EducationGraduation;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}