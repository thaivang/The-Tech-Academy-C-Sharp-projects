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
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Quotes { get; set; } 
    }
}