using Ecommerce.Model;
using Ecommerce_project.Implementation;
using Ecommerce_project.model;

namespace Ecommerce_project.Interface.cs
{
    public interface IDelivery
    {
         public void CreateDelivery(string firstName, string lastName, string email, string phoneNumber, int pin,string plateNumber);
         public void UpdateDelivery( string firstName, string lastName, string phoneNumber, string email);
         public void DeleteDelivery(string email);
         public Delivery GetDelivery(string email);
         public Delivery Login(string email, int pin); 
    }
}