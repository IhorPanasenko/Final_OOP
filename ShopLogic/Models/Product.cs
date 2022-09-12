﻿
namespace ShopLogic.Models
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalAmount { get; set; }
        public Category Category { get; set; }

        public Product(string name, string description, int totalAmount, Category category)
        {
            Name = name;
            Description = description;
            TotalAmount = totalAmount;
            Category = category;
        }

        public void Delete()
        {
            Console.WriteLine($"product {Name} in category {Category.Name} was deleted");
            Name = "";
            Description = "";
            TotalAmount = -1;
            Category.DeleteCategory();
        }

       public void Update(string? name = null, string? description = null, int totalAmount = -1, Category? category = null)
        {
            Name = name != null ? name : Name;
            Description = description != null ? description : Description;
            TotalAmount = totalAmount > 0 ? totalAmount : TotalAmount;
            Category = category != null ? category : Category;
        }
    }
}
