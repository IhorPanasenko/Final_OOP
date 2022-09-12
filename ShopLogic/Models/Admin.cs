

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

        public void CrateCategory()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCategory()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCategory()
        {
            throw new System.NotImplementedException();
        }

        public void CreateProduct()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProduct()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct()
        {
            throw new System.NotImplementedException();
        }
    }
}
