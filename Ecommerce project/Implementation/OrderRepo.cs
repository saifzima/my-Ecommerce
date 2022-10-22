using System;
using System.Collections.Generic;
using Ecommerce.Model;
using Ecommerce_project.Interface.cs;
using Ecommerce_project.model;

namespace Ecommerce_project.Implementation
{
    public class OrderRepo : IOrder
    {

        public static List<Order> listOfOrders = new List<Order>();
        
        ICustomer ctmg = new CustomerRepo();
        IProduct fmg = new ProductRepo();
        public void DeleteOrder(string refNumber)
        {

            Order adm = GetOrder(refNumber);
            if (adm != null)
            {
                listOfOrders.Remove(adm);
            }
            else
            {
                Console.WriteLine("order not found");
            }
        }


        public Order GetOrder(string refNumber)
        {
            foreach (var item in listOfOrders)
            {
                if (item.RefNumber == refNumber)
                {
                    return item;
                }
            }
            return null;
        }

        public void MakeOrder(string email,int id)
        {   
                Random rand = new Random();
                string refNumber = "Modem/plc" + rand.Next(100, 999).ToString();
                Customer cust = ctmg.GetCustomer(id);
                string customerName = cust.FirstName + " " + cust.LastName;
                string deliveryAddress = cust.Address;
                string status = "ordered";
                var orderedProduct = id;
                var x = fmg.GetProductId(orderedProduct);

            if (cust.Wallet < x.Price)
            {
                Console.WriteLine("insufficient balance");
                return;
            }
            else
            {
                
                double balance = cust.Wallet - x.Price;
                var order = new Order(id,refNumber,customerName,deliveryAddress,status,x.Price,x.ProductName);
                System.Console.WriteLine($"successful, your order reference is {refNumber}, price is {cust.Wallet} and new wallet balance {balance}");
            }
        }
        public double CalculatePrice(List<Product> asd)
        {
            double price = 0;
            foreach (var item in asd)
            {
                price += item.Price;
            }
            return price;
        }

        public void StatusToReady(string refNumber)
        {
            foreach (var item in listOfOrders)
            {
                if (item.OrderStatus == "ordered")
                {
                    item.OrderStatus = "Ready";
                }
            }
        }

    }
}