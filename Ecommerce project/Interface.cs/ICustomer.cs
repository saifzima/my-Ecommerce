using Ecommerce.Model;
namespace Ecommerce_project.Interface.cs
{
    public interface ICustomer
    {
      public void CreateCustomer (string firstName, string lastname, string email, int pin,string accountbalance, string phoneNumber);
      public void UpdateCustomer (string firstName, string lastname, string phoneNumber, int id);
      public void DeleteCustomer (int id);
      public Customer GetCustomer (int id); 
      public Customer Login (string email, int pin);
      public void AddMoneyToWallet(string email, double amount);  
      public void GetAllCustomer();
    }
}