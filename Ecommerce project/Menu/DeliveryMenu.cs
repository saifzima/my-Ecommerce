using System;
using Ecommerce.Model;
using Ecommerce_project.Implementation;
using Ecommerce_project.Interface.cs;
using Ecommerce_project.Menu;
namespace Ecommerce_project.Menu
{
    public class DeliveryMenu
    {
        DeliveryRepo Delivery = new DeliveryRepo();
        public void DA()
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

            Console.WriteLine("Enter you plateNumber");
            string plateNumber = Console.ReadLine();
            Delivery.CreateDelivery(fName, lName, email, phoneNumber,pin,plateNumber);
        }  
        public void LoginMenu()
        {
           Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

           Delivery.Login(email, pin);
            if(Delivery != null)
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