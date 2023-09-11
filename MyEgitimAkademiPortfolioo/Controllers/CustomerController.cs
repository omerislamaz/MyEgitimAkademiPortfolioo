using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademiPortfolioo.Models;

namespace MyEgitimAkademiPortfolioo.Controllers
{
    public class CustomerController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.Customer.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            db.Customer.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCustomer(int id)
        {
            var value = db.Customer.Find(id);
            db.Customer.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateCustomer(int id)
        {
            var value = db.Customer.Find(id);
            return View(value);
        }



        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            var value = db.Customer.Find(customer.CustomerID);
            value.CustomerID = customer.CustomerID;
            value.Title = customer.Title;
            value.Introduction = customer.Introduction;
            value.Deger = customer.Deger;
            value.DegerDescription = customer.DegerDescription;
            value.Resim1 = customer.Resim1;
          
          

            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}