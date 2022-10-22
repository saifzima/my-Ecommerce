using System;
using Ecommerce.Model;
using Ecommerce_project.Implementation;
using Ecommerce_project.Interface.cs;
using Ecommerce_project.Menu;
namespace Ecommerce_project.Menu
{

    public class AdminMenu
    {
        IAdmin admin = new Admins();
        ICustomer customer = new CustomerRepo();
        IProduct product = new ProductRepo();
        MainMenu menu = new MainMenu();

        public void AM()
        {
            Console.WriteLine("Enter 1 to Login\n Enter 2 to go back");
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {
                LoginMenu();
            }
            else if (Choice == 2)
            {
                MainMenu main = new MainMenu();
                main.MainEnterPoint();
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
            admin.CreateAdmin(fName, lName, email, pin, phoneNumber, position);

        }
        public void AdminWorkingMenu()
        {
            Console.WriteLine("Enter 1 to view all customer\nEnter 2 to add product\nEnter 0 to go to MainMenu");
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {
                customer.GetAllCustomer();
                AM();
            }
            else if (Choice == 2)
            {
                Console.Write("Enter your product name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Enter price");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Enter quality: ");
                string quality = Console.ReadLine();
                Console.WriteLine("Enter qauntity");
                int amount = int.Parse(Console.ReadLine());
                product.CreateProduct(productName, price, quality, amount);
                AdminWorkingMenu();
            }
            else if (Choice == 0)
            {
                menu.MainEnterPoint();
            }
            else
            {
                AM();

            }
        }
        public void LoginMenu()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());
            if (email == "ola@gmail.com" && pin == 12345)
            {
                Console.WriteLine("login successful");
                AdminWorkingMenu();
            }
            else
            {
                Console.WriteLine("wrong email or pin");
                LoginMenu();
            }
        }

    }
}