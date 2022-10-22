using System;
using Ecommerce_project.Menu;

namespace Ecommerce_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // var guid = Guid.NewGuid().ToString().ToLower();
            // System.Console.WriteLine(guid);
            // Console.WriteLine("Hello World!");

            MainMenu smallMenu = new MainMenu();
            smallMenu.MainEnterPoint();

             
        }
    }
}
