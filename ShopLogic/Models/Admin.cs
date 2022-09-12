

namespace ShopLogic
{
    internal class Admin : Person, IAdministration
    {
        string Login { get; set; }
        string Password { get; set; }


        internal Admin(string login, string password, string first_name, string last_name, DateTime birthDate, string emailAdress)
            : base(first_name, last_name, birthDate, emailAdress)
        {
            Login = login;
            Password = password;
        }
    }
}
