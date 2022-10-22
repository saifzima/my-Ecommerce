using System;
using Ecommerce.Model;

namespace Ecommerce_project.Interface.cs
{
    public interface IProduct
    {
         public void CreateProduct(string productName, double price, string quanlity,int amount);
        public void UpdateProduct (string productName,string newProductName, double newProductPrice );
        public void DeleteProduct (string productName);
        public Product GetProduct (string productName);
        public void GetAllProduct();
        public Product GetProductId(int id);
    }
}