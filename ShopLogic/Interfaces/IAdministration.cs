﻿using ShopLogic.Models;
using System.Net;

namespace ShopLogic.Interfaces
{
    internal interface IAdministration
    {
        public Category CrateCategory(string Name);
        public void DeleteCategory(Category category);
        public void UpdateCategory(Category category, string newName);
        public Product CreateProduct(string name, string description, int totalAmount, Category category, int price);
        public void DeleteProduct(Product product);
        public void UpdateProduct(Product product, string? name=null, string? description=null, int totalAmount=-1, Category? category=null, int price = -1);

        public void DeleteProductsWithZeroQuantity(Warehouse warehouse);

    }
}
