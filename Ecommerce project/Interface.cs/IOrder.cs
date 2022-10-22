
using Ecommerce_project.model;

namespace Ecommerce_project.Interface.cs
{
    public interface IOrder
    {
        public void MakeOrder(string email,int id);
        public void DeleteOrder(string refNumber);
        public Order GetOrder(string refNumber);
        public void StatusToReady(string refNumber);
        
    }
}