using System;
using System.Collections.Generic;
using Ecommerce.Model;
using Ecommerce_project.Interface.cs;

namespace Ecommerce_project.Implementation
{
    public class Admins : IAdmin
    {
        public static List<Admin> listOfAdmins= new List<Admin>();
        public void CreateAdmin(string firstName, string lastName, string email, int pin, string phoneNumber, string position)
        {
            Random rand = new Random();
            int id = listOfAdmins.Count +1;
            string staffId ="Modem/plc"+rand.Next(100, 999).ToString();
            Admin admin =new Admin(id,firstName, lastName,email,phoneNumber, pin, position, staffId );
            Console.WriteLine($"Dear  {firstName}, and  you identities is {id}");
        }

        public void DeleteAdmin(string staffId)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdmins(string staffId)
        {
            Admin adm = GetAdmin(staffId);
            if(adm != null)
            {
                listOfAdmins.Remove(adm);
            }
            else
            {
                Console.WriteLine("admin not found");
            }
        }

        public Admin GetAdmin(string staffId)
        {
            foreach (var item in listOfAdmins)
            {
                if(item.StaffID  == staffId)
                {
                    return item;
                }
            }
            return null;
        }

        public Admin Login(string email, int pin)
        {
         foreach (var item in listOfAdmins)
            {
                if (item.Email == "ola@gmail.com" && item.Pin == 12345)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateAdmin(string firstName, string lastname, string phoneNumber,string staffId)
        {
            Admin ad = GetAdmin(staffId);
            if(ad == null)
            {
                Console.WriteLine("Admin not found");
            }
            else
            {
                ad.FirstName = firstName;
                ad.LastName = lastname;
                ad.PhoneNumber = phoneNumber;
            }
        }
    }

   
}