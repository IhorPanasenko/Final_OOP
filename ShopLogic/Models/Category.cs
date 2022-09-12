
using System;
using System.Data;

namespace ShopLogic.Models
{
    internal class Category
    {
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }
        public void UpdateCategory(string newName)
        {
            Name = newName!=null?newName:Name;
        }
        public void DeleteCategory()
        {
            Name = $"Category {Name} Was Deleted";
        }
    }
}
