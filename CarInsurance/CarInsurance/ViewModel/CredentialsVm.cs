using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModel
{
    public class CredentialsVm//print all props to admin
    {
        //map database objects to view model
        //separates the objects based on parameters in the VM to the view
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateofBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public int FullcoverageLiability { get; set; }
        public decimal Quotes { get; set; }
    }
}