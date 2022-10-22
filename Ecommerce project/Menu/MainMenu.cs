using System;
using Ecommerce_project.Implementation;
using Ecommerce_project.Interface;
using Ecommerce_project.Menu;namespace Ecommerce_project.Menu
{
    public class MainMenu
    {
        public void MainEnterPoint()
        {
            Console.WriteLine("Welcome to Modem/plc \nHow can we help you");

            Console.WriteLine("Enter 1 as Admin\nEnter 2 as Customer\nEnter 3 as Delivery");
            int opt = int.Parse(Console.ReadLine());
            if(opt == 1)
            {
                AdminMenu am = new AdminMenu();
                am.AM();
                
            }

            else if(opt == 2)
            {
                CustomerMenu cm = new CustomerMenu();
                cm.CA();
            }
            else if(opt == 3)
            {
                DeliveryMenu Dm =new DeliveryMenu();
                Dm.DA();
            }
           
        }
    }
}