
using System;

namespace ShopLogic
{
    internal class Customer : Person, IBuyable
    {
        string Login { get; set; }
        string Password { get; set; }
        DateTime DateOfRegistration { get; init; }


        internal Customer(string login, string password, DateTime dateOfRegistration, string first_name, string last_name, DateTime birthDate, string emailAdress)
            : base(first_name, last_name, birthDate, emailAdress)
        {
            Login = login;
            Password = password;
            DateOfRegistration = dateOfRegistration;
        }

        void IBuyable.Buy()
        {
            throw new NotImplementedException();
        }
    }
}
