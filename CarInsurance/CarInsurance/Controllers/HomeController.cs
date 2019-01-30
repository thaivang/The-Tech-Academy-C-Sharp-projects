using CarInsurance.ViewModel;
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
        public ActionResult SignUp(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, string dUI, int speedingTickets, int fullCoverageLiability)
        {
            decimal quoteTotal = 50;// start with a base of $50 
            using (CarInsuranceEntities db = new CarInsuranceEntities())// instantiate the partial class, allow objects to access the database
            {
                var signup = new CarSignUp();//new object from partial class === why?


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

                //user age 
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

                //car year 
                if (carYear < 2000 || carYear > 2015)//add 25 
                {
                    quoteTotal += 25;
                }

                //car make
                if (carMake.ToLower().Contains("porsche") && carModel.ToLower().Contains("911 carrera"))//multiple conditions must come first otherwise a single condition will only execute like the if else condition
                {
                    quoteTotal += 50;
                }
                else if (carMake.ToLower().Contains("porsche"))//checks and lowers user input 
                {
                    quoteTotal += 25;
                }

                //Speeding Tickets
                if (speedingTickets == 0)
                {
                    speedingTickets *= 10; //for each tickets multiply by 10 and add to pending total
                }
                else
                {
                    speedingTickets *= 10;
                    quoteTotal += speedingTickets;
                }
                
                //DUI add 10%
                if (dUI.ToLower().Contains("yes"))// if yes pending total is nulyiply by 0.25
                {
                    decimal DuiCharge = quoteTotal * 0.25m;
                    quoteTotal += DuiCharge;
                }
                else if (dUI.ToLower().Contains("no"))//does not return value 
                {
                    quoteTotal += 0;
                }

                //Full coverage or liability
                if (fullCoverageLiability == 1 )
                {
                    decimal fullCoverage = quoteTotal * 0.50m;
                    quoteTotal += fullCoverage;
                }
                else if (fullCoverageLiability == 0)//does not return value
                {
                    quoteTotal += 0;
                }


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
                signup.Quotes = quoteTotal;
               

                db.CarSignUps.Add(signup);//pass signup object 
                db.SaveChanges();
            }

            CredentialsVm newQuote = new CredentialsVm();
            newQuote.FirstName = firstName;
            newQuote.LastName = lastName;
            newQuote.EmailAddress = emailAddress;
            newQuote.Quotes = quoteTotal;
            return View(newQuote);

            //return View("~/Views/Home/Quote.cshtml");
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