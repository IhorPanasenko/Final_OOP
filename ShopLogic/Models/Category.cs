
using ShopLogic.Interfaces;
using System;
using System.Data;

namespace ShopLogic.Models
{
    internal class Category : ICRUD
    {
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }

        public void Update(string newName)
        {
            Name = newName != null ? newName : Name;
        }

        public void Delete()
        {
            Name = $"Category {Name} Was Deleted";
        }
    }
}
