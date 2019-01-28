using CarInsurance.Models;
using CarInsurance.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class Testadmin : Controller
    {
        // GET: Admin
        //public ActionResult Index()
        //{
        //    using (CarInsuranceEntities db = new CarInsuranceEntities())//instantiate the entity object which gives access to the database
        //    {
        //        var carsignups = db.CarSignUps; //var car = db.CarSignUps which represents all the records in the database 
        //        var credentialsVms = new List<CredentialsVm>();//created new list of viewmodel to store values in to output to view
        //        foreach (var credentials in carsignups)//gathers all information from db.CarSignUps
        //        {
        //            var credentialVm = new CredentialsVm();//each new object from type CVM which will hold all variables 
        //            credentialVm.FirstName = credentials.FirstName;//var credentialVM assign to a new type which takes property
        //            credentialVm.LastName = credentials.LastName;
        //            credentialVm.EmailAddress = credentials.EmailAddress;
        //            credentialVm.Quotes = credentials.Quotes;
        //            credentialsVms.Add(credentialVm);//adds to list
        //        }

        //        return View(credentialsVms);//returns all necessary data to admin
        //    }
        //}
        //[HttpPost]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    using (CarInsuranceEntities db = new CarInsuranceEntities())
        //    {
        //        var carsignup = db.CarSignUps.Find(id);
        //        db.CarSignUps.Remove(id);
        //        db.SaveChanges();
        //    }

        //    return RedirectToAction("Index");
        //}

    }
}