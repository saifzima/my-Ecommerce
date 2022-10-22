namespace Ecommerce.Model
{
    public abstract class Person 
    {
        public int Id{ get; set; }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string PhoneNumber { get;set;}
        public int Pin {get; set;}
        public Person(int id, string firstName,string lastName, string email,string phoneNumber,int pin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

    }
}