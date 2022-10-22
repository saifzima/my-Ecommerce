using System;
using System.Collections.Generic;
using Ecommerce.Model;
using Ecommerce_project.Interface.cs;
using Ecommerce_project.model;

namespace Ecommerce_project.Implementation
{
    public class DeliveryRepo : IDelivery
    {
        public static List<Delivery> listOfDelivery = new List<Delivery>();
        public void CreateDelivery(string firstName, string lastName, string email, string phoneNumber, int pin,string plateNumber)
        {
            Random rand = new Random();
            int id = listOfDelivery.Count + 1;
            var dlm = new Delivery(id, firstName, lastName, email,phoneNumber, pin, plateNumber);
            listOfDelivery.Add(dlm);
            Console.WriteLine($"thank you mr {dlm.FirstName}, your staff identity number is {dlm.Id}");

        }

        public void  DeleteDelivery(string email)
        {
            Delivery adm = GetDelivery(email);
            if (adm != null)
            {
                listOfDelivery.Remove(adm);
            }
            else
            {
                Console.WriteLine("Delivery not found");
            }
        }

        public Delivery GetDelivery(string email)
        {
            foreach (var item in listOfDelivery)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public Delivery Login(string email, int pin)
        {
              foreach (var item in listOfDelivery)
            {
                if (item.Email == email && item.Pin == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateDelivery(string firstName, string lastName, string phoneNumber, string email)
        {
             var ad = GetDelivery(email);
            if (ad == null)
            {
                Console.WriteLine("Delivery not found");
            }
            else
            {
                ad.FirstName = firstName;
                ad.LastName = lastName;
                ad.PhoneNumber = phoneNumber;
            }
        }
    }
}