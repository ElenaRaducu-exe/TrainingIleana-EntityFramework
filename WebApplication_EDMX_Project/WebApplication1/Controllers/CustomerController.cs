using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        private TrainingIleanaREntities _context = new TrainingIleanaREntities();

        // GET: customer1/Read
        [HttpGet]
        public ActionResult Read()
        {
            var customersData = _context.customers1.ToList();
            return View(customersData);
        }

        // GET: customer1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            customer1 customer1 = _context.customers1.Find(id);
            if (customer1 == null)
            {
                return HttpNotFound();
            }
            return View(customer1);
        }

        // GET: customer1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: customer1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "customer_id,first_name,last_name,phone,email,street,city,state,zip_code,full_name")] customer1 customer1)
        {
            if (ModelState.IsValid)
            {
                if(customer1.first_name != null && customer1.last_name != null)
                {
                    customer1.full_name = customer1.first_name + " " + customer1.last_name;
                }

                _context.customers1.Add(customer1);
                _context.SaveChanges();
                return RedirectToAction("Read");
            }

            return View(customer1);
        }

        // GET: customer1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            customer1 customer1 = _context.customers1.Find(id);
            if (customer1 == null)
            {
                return HttpNotFound();
            }
            return View(customer1);
        }

        // POST: customer1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "customer_id,first_name,last_name,phone,email,street,city,state,zip_code,full_name")] customer1 customer1)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(customer1).State = EntityState.Modified;
                customer1.full_name = customer1.first_name + ' ' + customer1.last_name;
                _context.SaveChanges();
                return RedirectToAction("Read");
            }
            return View(customer1);
        }

        // GET: customer1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            customer1 customer1 = _context.customers1.Find(id);
            if (customer1 == null)
            {
                return HttpNotFound();
            }
            return View(customer1);
        }

        // POST: customer1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            customer1 customer1 = _context.customers1.Find(id);
            _context.customers1.Remove(customer1);
            _context.SaveChanges();
            return RedirectToAction("Read");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
