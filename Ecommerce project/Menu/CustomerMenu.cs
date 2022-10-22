using System;
using Ecommerce.Model;
using Ecommerce_project.Implementation;
using Ecommerce_project.Interface;
using Ecommerce_project.Menu;
using static Ecommerce_project.Implementation.CustomerRepo;

namespace Ecommerce_project.Menu
{
    public class CustomerMenu
    {
        CustomerRepo customer =new CustomerRepo();
        public void CA()
        {
          Console.WriteLine("Enter 1 to Register\n Enter 2 to Login");
            int Choice = int.Parse(Console.ReadLine());
            if(Choice == 1)
            {
                RegisterMenu();
            }
            else if(Choice ==2)
            {
                LoginMenu();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }  
        }
        public void RegisterMenu()
        {
             Console.WriteLine("Welcome to Admin ");

            Console.Write("Enter your first name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lName = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            Console.Write("Enter your phoneNumber: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter you position");
            string position = Console.ReadLine();
            customer.CreateCustomer(fName, lName, email, pin, phoneNumber,position);
            LoginMenu();
        }
        public void LoginMenu()
        {
           Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

           customer.Login(email, pin);
            if(customer != null)
            {
                Console.WriteLine("login successful");
            }
            else
            {
                Console.WriteLine("wrong email or pin");
            }   
        }


    }
}