namespace Ecommerce_project.model
{
    public class Order
    {
        public int Id{ get; set; }
        public string RefNumber{ get; set; }
        public string CustomerName {get; set;}
        public string DeliveryAddress {get; set;}
        public string OrderStatus {get; set;}
        public double TotalPrice {get; set;}
        public string OrderedProduct { get; set; }

        public Order (int id, string refNumber, string customerName, string deliveryAddress, string orderStatus, double totalPrice, string orderedProduct)
        {
            Id = id;
            RefNumber = refNumber;
            CustomerName = customerName; 
            DeliveryAddress = deliveryAddress;
            OrderStatus = orderStatus;
            TotalPrice = totalPrice;
            OrderedProduct = orderedProduct;
        }

    }
}