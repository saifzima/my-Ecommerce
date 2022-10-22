using System;
using Ecommerce_project.Implementation;
using Ecommerce_project.Interface;
using Ecommerce_project.Menu;
namespace Ecommerce.Model
{
    public class Admin : Person
    {
        public string Position{get;set;}
        public string StaffID {get; set;}
        public Admin(int id, string firstName,string lastName, string email,string phoneNumber,int pin,string position,string staffId) : base  (id, firstName, lastName, email, phoneNumber, pin)
        {
            Position = position;
            StaffID = staffId;
        }
    }      

}