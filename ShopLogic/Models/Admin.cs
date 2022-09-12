
using ShopLogic.Interfaces;
using System;

namespace ShopLogic.Models
{
    internal class Admin : Person, IAdministration
    {
        public string Login { get; set; }
        public string Password { get; set; }


        public Admin(string login, string password, string first_name, string last_name, DateTime birthDate, string emailAdress)
            : base(first_name, last_name, birthDate, emailAdress)
        {
            Login = login;
            Password = password;
        }

        public Category CrateCategory(string Name)
        {
            return new Category(Name);
        }

        public void DeleteCategory(Category category)
        {
            category.DeleteCategory();
        }

        public void UpdateCategory()
        {
            throw new NotImplementedException();
        }

        public void CreateProduct()
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct()
        {
            throw new NotImplementedException();
        }
    }
}
