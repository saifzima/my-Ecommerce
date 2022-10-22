using System;
using Ecommerce.Model;
using Ecommerce_project.Implementation;
using Ecommerce_project.Interface;
using Ecommerce_project.Menu;

namespace Ecommerce_project.model
{
    public class Delivery : Person
    {
     public string PlateNumber {get; set;}

        public Delivery(int id, string firstName,string lastName, string email,string phoneNumber,int pin, string plateNumber) : base(id, firstName, lastName, email, phoneNumber, pin) 
        {
            PlateNumber = plateNumber;
        }
    }
}