
using System;
using System.Data;

namespace ShopLogic.Models
{
    internal class Category
    {
        internal string Name { get; set; }
        public List<Product> ProductsInCategory { get; set; }

        public Category(string name)
        {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentException("Name of category cant be null or empty");
          
            Name = name;
            ProductsInCategory = new List<Product>();
        }
        public void UpdateCategory(string newName)
        {
            Name = newName!=null?newName:Name;
        }

        public void AddProduct(Product product)
        {
            int index = ProductsInCategory.IndexOf(product);
            if (index == -1)
            {
               ProductsInCategory.Add(product);
            }
            else
            {
                Console.WriteLine("This Product is in category");
            }
        }
        public void DeleteCategory()
        {
            Console.WriteLine($"Category {Name} Was Deleted");
            ProductsInCategory.Clear();
            Name = "";
        }

        public override string ToString()
        {
            string res = $"\nName of Category: {Name}\n";
            foreach (Product product in ProductsInCategory)
            {
                res+= product.ToString();
            }
            return res;
        }

    }
}
