using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //display information to user, total price
        {
            return View();
        }

        [HttpPost]//Parameter name must be the same as the inputname in index.cshtml otherwise error
        public ActionResult SignUp(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, string dUI, int speedingTickets, string fullCoverageLiability)
        {
            int quoteTotal = 50;
            using (CarInsuranceEntities db = new CarInsuranceEntities())// instantiate the partial class, allow objects to access the database
            {
                var signup = new CarSignUp();//new object from partial class === why?
                signup.FirstName = firstName;
                signup.LastName = lastName;
                signup.EmailAddress = emailAddress;
                signup.DateOfBirth = dateOfBirth;
                signup.CarYear = carYear;
                signup.CarMake = carMake;
                signup.CarModel = carModel;
                signup.DUI = dUI;
                signup.SpeedingTickets = speedingTickets;
                signup.FullCoverageLiability = fullCoverageLiability;


                int userAge = Convert.ToDateTime(dateOfBirth).Year;
                int timeNow = Convert.ToDateTime(DateTime.Today).Year;
                int ageDiff = timeNow - userAge;

                //============== code intentions ============
                //> obtain exact age then compare it with system date using month day and year
                //e.g. DOB = 5/5/1995. Today = 5/4/2019. age = 24 but they are 23 years old not 24.

                //DateTime now = DateTime.Today
                //int age = now.Year - dateOfBirth.Year;

                //if (dateOfBirth < now.AddYears(-age)) age--;// subtract age 
                //{

                //    quoteTotal += 100;
                //}
                //else if (dateOfBirth > 18 && dateOfBirth < 25)
                //{
                //    quoteTotal += 25;
                //}

                //> will calculate only the year not month or day 
                if (ageDiff < 18)
                {

                    quoteTotal += 100;
                }
                else if (ageDiff > 18 && ageDiff < 25)
                {
                    quoteTotal += 25;
                }
                else if (ageDiff > 100)
                {
                    quoteTotal += 25;
                }

                signup.Quotes = quoteTotal;
                //add the object ^ to the database
                db.CarSignUps.Add(signup);//pass signup object 
                db.SaveChanges();
                
            }

            return View("~/Views/Home/Quote.cshtml");
            //return RedirectToAction("Quote", "Home");//redirects to Quote to perform the logic after user enters information
        }

        //========= Intentions for code to work ========

        //> use the actionresult signup to redirect to this actionresult Quote for organization purposes(separation between logical and user input)
        //> unfortunately I was not able to figure out how to retrieve data and use that data to do logic
        //> Intentions> grab the highest Id (because everytime a user submits info to the DB the id increments by 1) and select the column name DateOfBirth in the database using highest Id

        //public ActionResult Quote(DateTime? DateOfBirth)//pass Quote, DateOfBirth inside ()
        //{

        //    using (CarInsuranceEntities db = new CarInsuranceEntities())
        //    {

        //        //CarSignUp Quote = new CarSignUp();
        //        

        //        //signup.DateOfBirth = DateTime.Now.ToString("dd/MM/yyyy"); //was considering using this code but not in use for this purposes
        //        //var dateofBirth = DateTime.Now.year;

        //        CarSignUp Quote = new CarSignUp();
        //        int maxId = db.CarSignUps.Max(p => p.Id).CompareTo; 
        //        var t = DateOfBirth;

        //        int quoteTotal = 50;

        //        if (DateTime.Now < DateOfBirth)
        //        {
        //            quoteTotal += 25;
        //        }
        //        db.CarSignUps.Add(Quote);

        //    }
        //    return View("~/Views/Home/Quote.cshtml");//redirects from home controller to Quote then to total amount 
        //}
    }
}