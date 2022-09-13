﻿
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

        public void DeleteCategory(Category category)
        {
            category.DeleteCategory();
        }

        public void UpdateCategory(Category category, string newName)
        {
            category.UpdateCategory(newName);
        }

        public Product CreateProduct(string name, string description, int totalAmount, Category category, int price)
        {
            return new Product(name, description, totalAmount, category, price);  
        }

        public void DeleteProduct(Product product)
        {
            product.Delete();
        }

        public void UpdateProduct(Product product, string? name = null, string? description = null, int totalAmount = -1, Category? category = null, int price=-1)
        {
            product.Update(name, description, totalAmount, category, price);
        }

        public Warehouse CreateWarehouse(string address)
        {
            return new Warehouse(address);
        }

        public void PutProductToWarehouse(Warehouse warehouse, Product product)
        {
            warehouse.PutProductToWarehouse(product);   
        }

        public void ChangeWarehouseAddress(Warehouse warehouse, string address)
        {
            warehouse.ChangeWarehouseAddress(address);
        }

        public void DeleteProductFromWarehouse(Warehouse warehouse, Product product)
        {
            warehouse.DeleteProductFromWarehouse(product);
        }

        public void DelteWarehouse(Warehouse warehouse)
        {
            warehouse.DelteWarehouse();
        }

        public void DeleteProductsWithZeroQuantity(Warehouse warehouse)
        {
            warehouse.DeleteProductsWithZeroQuantity();
        }

        public E_shop CreateShop()
        {
            return new E_shop();
        }

        public void DeleteShop(E_shop e_Shop)
        {
            e_Shop.DeleteShop();
        }

        public void AddWarehouse(E_shop e_Shop, Warehouse warehouse)
        {
            e_Shop.AddWarehouse(warehouse);
        }

        public void DeleteWarehouse(E_shop e_Shop, Warehouse warehouse)
        {
            e_Shop.DeleteWarehouse(warehouse);
        }
    }
}
