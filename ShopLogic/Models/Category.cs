
using System;
using System.Data;

namespace ShopLogic.Models
{
    internal class Category
    {
        internal string Name { get; set; }

        public Category(string name)
        {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentException("Name of category cant be null or empty");
          
            Name = name;
        }
        public void UpdateCategory(string newName)
        {
            Name = newName!=null?newName:Name;
        }
        public void DeleteCategory()
        {
            Console.WriteLine($"Category {Name} Was Deleted");
            Name = "";
        }
    }
}
