﻿using ShopLogic.Models;

namespace ShopLogic.Interfaces
{
    internal interface IAdministration
    {
        public Category CrateCategory(string Name);
        public void DeleteCategory();
        public void UpdateCategory(Category category, string newName);
        public void CreateProduct();
        public void DeleteProduct();
        public void UpdateProduct();
        
    }
}
