
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

        public void UpdateCategory(Category category, string newName)
        {
            category.UpdateCategory(newName);
        }

        public Product CreateProduct(string name, string description, int totalAmount, Category category)
        {
            return new Product(name, description, totalAmount, category);  
        }

        public void DeleteProduct(Product product)
        {
            product.Delete();
        }

        public void UpdateProduct(Product product, string? name = null, string? description = null, int totalAmount = -1, Category? category = null)
        {
            product.Update(name, description, totalAmount, category);
        }
    }
}
