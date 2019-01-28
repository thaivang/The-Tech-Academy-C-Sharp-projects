using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private CarInsuranceEntities db = new CarInsuranceEntities();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.CarSignUps.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarSignUp carSignUp = db.CarSignUps.Find(id);
            if (carSignUp == null)
            {
                return HttpNotFound();
            }
            return View(carSignUp);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,CarYear,CarMake,CarModel,DUI,FullCoverageLiability,Quotes,DateOfBirth")] CarSignUp carSignUp)
        {
            if (ModelState.IsValid)
            {
                db.CarSignUps.Add(carSignUp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carSignUp);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarSignUp carSignUp = db.CarSignUps.Find(id);
            if (carSignUp == null)
            {
                return HttpNotFound();
            }
            return View(carSignUp);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,CarYear,CarMake,CarModel,DUI,FullCoverageLiability,Quotes,DateOfBirth")] CarSignUp carSignUp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carSignUp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carSignUp);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarSignUp carSignUp = db.CarSignUps.Find(id);
            if (carSignUp == null)
            {
                return HttpNotFound();
            }
            return View(carSignUp);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarSignUp carSignUp = db.CarSignUps.Find(id);
            db.CarSignUps.Remove(carSignUp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
