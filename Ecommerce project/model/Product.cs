using System;
namespace Ecommerce.Model
{
    public  class Product 
    {
        public int Id{get;set;}
        public string ProductName {get;set;}
        public double Price {get;set;}
        public string Quality {get;set;}
        public Guid RefNo {get;set;} = Guid.NewGuid();
        public  int Amount{get;set;}  
        
        public Product(int id, string productName,double price, string quality ,int amount )
        {
            Id  = id;
            ProductName = productName;
            Price = price;
            Quality = quality;
            Amount = amount;
        }
    }
}