using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using ASP_NET_MVC_1.Models;

namespace ASP_NET_MVC_1.Controllers
{ 
    public class TFLController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        //
        // GET: /TFL/

        public ViewResult Index()
        {
            return View(db.employees.ToList());
        }

        //
        // GET: /TFL/Details/5

        public ViewResult Details(int id)
        {
            Employee employee = db.employees.Find(id);
            return View(employee);
        }

        //
        // GET: /TFL/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /TFL/Create

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(employee);
        }
        
        //
        // GET: /TFL/Edit/5
 
        public ActionResult Edit(int id)
        {
            Employee employee = db.employees.Find(id);
            return View(employee);
        }

        //
        // POST: /TFL/Edit/5

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //
        // GET: /TFL/Delete/5
 
        public ActionResult Delete(int id)
        {
            Employee employee = db.employees.Find(id);
            return View(employee);
        }

        //
        // POST: /TFL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Employee employee = db.employees.Find(id);
            db.employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}