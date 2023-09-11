using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademiPortfolioo.Models;

namespace MyEgitimAkademiPortfolioo.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialQuickContact()
        {

            var values = db.QuickContact.ToList();
         
            return PartialView(values);
         
        }

       
        public PartialViewResult PartialFeature()
        {
           
            var values = db.About.ToList();

            return PartialView(values); 
        }
        public PartialViewResult PartialService()
        {
            var values = db.Service.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialEducation()
        {
            var values = db.Education.ToList();
        
            return PartialView(values);
          
        }

        public PartialViewResult PartialCareer()
        {
            var values = db.Career.ToList();

            return PartialView(values);
        }

        public PartialViewResult PartialClientPartners()
        {
            var values = db.Customer.ToList();
            return PartialView(values);
        }

     
        public PartialViewResult PartialTestimonial()
        {
            var values = db.Testimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialContact()
        {
            return PartialView();
        }

       

    }
}