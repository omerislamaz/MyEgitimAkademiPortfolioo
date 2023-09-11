using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademiPortfolioo.Models;

namespace MyEgitimAkademiPortfolioo.Controllers
{
    public class QuickContactMenuController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()

        {
            var values = db.QuickContact.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddQuickContact()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddQuickContact(QuickContact quickContact)
        {
            db.QuickContact.Add(quickContact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateQuickContact(int id)
        {
            var value = db.QuickContact.Find(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult UpdateQuickContact(QuickContact quickContact)
        {
            var value = db.QuickContact.Find(quickContact.QuickContactId);
            value.QuickContactId = quickContact.QuickContactId;
            value.İsimSoyisim = quickContact.İsimSoyisim;
            value.Resim = quickContact.Resim;
            value.Aciklama = quickContact.Aciklama;
            value.Telefon = quickContact.Telefon;
            value.Email = quickContact.Email;
            value.Behance = quickContact.Behance;
            value.Linkedin = quickContact.Linkedin;
            value.Facebook = quickContact.Facebook;
            value.Twiter = quickContact.Twiter;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}