namespace Ecommerce.Model
{
    public class Customer : Person
    {
        public string AccountBalance{get;set;}
        public double Wallet {get; set;}
        public string Address { get; internal set; }

        public Customer(int id, string firstName,string lastName, string email,string phoneNumber,int pin,string accountbalance,double wallet) : base  (id, firstName, lastName, email, phoneNumber, pin)
       {
        AccountBalance = accountbalance;
        Wallet = wallet;
       }

    }
}