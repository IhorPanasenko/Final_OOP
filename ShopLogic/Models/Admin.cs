
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
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Login and password cant be null or empty");
            }
            else if (password.Length < 6)
            {
                throw new ArgumentException("Password cannot be shorter than six characters");
            }

            Login = login;
            Password = password;
        }

        public Category CrateCategory(string Name)
        {
            return new Category(Name);
        }

        public void DeleteCategory(Warehouse warehouse, Category category)
        {
            warehouse.DeleteCategory(category);
            category.DeleteCategory();
        }

        public void UpdateCategory(Category category, string newName)
        {
            category.UpdateCategory(newName);
        }

        public Product CreateProduct(string name, string description, int totalAmount, int price)
        {
            return new Product(name, description, totalAmount, price);  
        }

        public void DeleteProduct(Category category, Product product)
        {
            category.DeleteProduct(product);
            product.Delete();
        }

        public void UpdateProduct(Product product, string? name = null, string? description = null, int totalAmount = -1, int price=-1)
        {
            product.Update(name, description, totalAmount, price);
        }

        public void PutProductInShop(E_shop shop, Warehouse warehouse, Category category, Product product)
        {
            shop.PutProductInWarehouse(warehouse, category, product);   
        }
    }
}
