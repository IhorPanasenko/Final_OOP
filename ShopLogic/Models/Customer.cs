
using System;

namespace ShopLogic.Models
{
    internal class Customer : Person, IBuyable
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateOfRegistration { get; init; }
        public CreditCard? CreditCard { get; set; }

        public Customer(string login, string password, DateTime dateOfRegistration, string first_name, string last_name, DateTime birthDate, string emailAdress)
            : base(first_name, last_name, birthDate, emailAdress)
        {
            Login = login;
            Password = password;
            DateOfRegistration = dateOfRegistration;
        }
        
        public void RegisterCreditCard(int Number, decimal Money)
        {
            CreditCard = new CreditCard(Number, Money);
        }

        public void Buy()
        {
            throw new NotImplementedException();
        }
    }
}
