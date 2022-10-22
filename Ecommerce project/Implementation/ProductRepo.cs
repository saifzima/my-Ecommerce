using System;
using System.Collections.Generic;
using Ecommerce.Model;
using Ecommerce_project.Interface.cs;
namespace Ecommerce_project.Implementation
{
    public class ProductRepo : IProduct
    {
        public static List<Product> listOfProduct = new List<Product>();
        public void CreateProduct(string productName, double price, string quality,int amount )
        {
           Random rand = new Random();
            int id = listOfProduct.Count + 1;
            Product fd = new Product(id,productName,price, quality, amount );
            Console.WriteLine($"thank you, {productName} created succesfully");

        }
        public void DeleteProduct(string productName)
        {
            Product adm = GetProduct(productName);
            if (adm != null)
            {
                listOfProduct.Remove(adm);
            }
            else
            {
                Console.WriteLine("food not found");
            }
        }

        public void GetAllProduct()
        {
            foreach (var item in listOfProduct)
            {
                Console.Write($"{item.Id}\t{item.ProductName}\t{item.Price}");
            }
            Console.WriteLine();
        }

        public Product GetProduct(string productName)
        {
          foreach (var item in listOfProduct)
            {
                if (item.ProductName == productName)
                {
                    return item;
                }
            }
            return null;
        }
        public Product GetProductId(int id)
        {
          foreach (var item in listOfProduct)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public void UpdateProduct(string productName, string newProductName, double newProductPrice)
        {
         Product ad = GetProduct(productName);
            if (ad == null)
            {
                Console.WriteLine("food not found");
            }
            else
            {
                ad.ProductName = newProductName;
                ad.Price = newProductPrice;
            }
        }
    }    
}
        