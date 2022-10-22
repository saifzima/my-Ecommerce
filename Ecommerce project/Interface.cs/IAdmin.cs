using Ecommerce.Model;
using Ecommerce_project.Implementation;
namespace Ecommerce_project.Interface.cs
{
    public interface IAdmin
    {
        public void CreateAdmin (string firstName, string lastName, string email, int pin, string phoneNumber, string position);
       public void UpdateAdmin (string firstName, string lastname, string phoneNumber,string staffId);
       public void DeleteAdmin (string staffId);
       public Admin GetAdmin (string staffId);
       public Admin Login (string email, int pin);
    }
    
    
}