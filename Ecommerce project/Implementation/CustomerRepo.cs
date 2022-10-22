using System;
using System.Collections.Generic;
using Ecommerce.Model;
using Ecommerce_project.Interface.cs;

namespace Ecommerce_project.Implementation
{
    public class CustomerRepo : ICustomer
    {
        public static List<Customer> listOfCustomer = new List<Customer>();

        public void CreateCustomer(string firstName, string lastName, string email, int pin, string accountbalance, string phoneNumber)
        {
            Random rand = new Random();
            int id = listOfCustomer.Count + 1;
            double wallet = 5000;
            string staffId = "Modem/plc" + rand.Next(100, 999).ToString();
            Customer adm = new Customer(id, firstName, lastName, email, phoneNumber, pin, accountbalance, wallet);
            Console.WriteLine($"thank you Mr/Mrs {firstName} for your service");

        }

        public void DeleteCustomer(int id)
        {
            Customer adm = GetCustomer(id);
            if (adm != null)
            {
                listOfCustomer.Remove(adm);
            }
            else
            {
                Console.WriteLine("customer not found");
            }
        }



        public Customer GetCustomer(int id)
        {
            foreach (var item in listOfCustomer)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public void GetAllCustomer()
        {

            if (listOfCustomer.Count > 0)
            {
                foreach (var item in listOfCustomer)
                {
                    Console.WriteLine(item.FirstName + "" + item.LastName);
                }
            }
            else
            {
                Console.WriteLine("No customer exist");
            }
        }


        public Customer GetCustomerByEmail(string email)
        {
            foreach (var item in listOfCustomer)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public Customer Login(string email, int pin)
        {
            foreach (var item in listOfCustomer)
            {
                if (item.Email == email && item.Pin == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateCustomer(string firstName, string lastName, string phoneNumber, int id)
        {
            Customer ad = GetCustomer(id);
            if (ad == null)
            {
                Console.WriteLine("Customer not found");
            }
            else
            {
                ad.FirstName = firstName;
                ad.LastName = lastName;
                ad.PhoneNumber = phoneNumber;
            }
        }

        public void AddMoneyToWallet(string email, double amount)
        {
            Customer adm = GetCustomerByEmail(email);
            if (adm != null)
            {
                adm.Wallet += amount;
                System.Console.WriteLine($"{amount} successfully added to wallet and balance is {adm.Wallet}");

            }
            else
            {
                Console.WriteLine("customer not found");
            }
        }
    }

}