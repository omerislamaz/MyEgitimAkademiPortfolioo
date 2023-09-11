﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademiPortfolioo.Models;

namespace MyEgitimAkademiPortfolioo.Controllers
{
    public class ContactController : Controller
    {

        MyPortfolioDbEntities db = new MyPortfolioDbEntities();


        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.description = db.Address.Select(x => x.Descripton).FirstOrDefault();
            ViewBag.phone = db.Address.Select(x => x.Phone).FirstOrDefault();
            ViewBag.adressDetail = db.Address.Select(x => x.AddressDetail).FirstOrDefault();
            ViewBag.mail = db.Address.Select(x => x.Mail).FirstOrDefault();

            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {

            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index","Default");
        }

       
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}