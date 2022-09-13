
using System.Collections.Generic;
using System.ComponentModel;

namespace ShopLogic.Models
{
    internal class Warehouse
    {
        public List<Category> WarehouseCategories { get; set; }
        public string Address { get; set; }

        public Warehouse(string adress)
        {
            WarehouseCategories = new List<Category>();
            Address = adress;
        }
        public void AddCategoryToWarehouse(Category category)
        {
            WarehouseCategories.Add(category);
        }

        public void ChangeWarehouseAddress(string address)
        {
            Address = address != null ? address : Address;
        }

        public void DeleteCategory(Category category)
        {
            int index = WarehouseCategories.IndexOf(category);
            if (index != -1)
            {
                WarehouseCategories.RemoveAt(index);
            }
        }

        public void DeleteProductFromWarehouse(Product product)
        {
           /* if (IsInWarehouse(product)){
                int position = FindProductPosition(product);
                WarehouseProduct.RemoveAt(position);
            }
            else
            {
                Console.WriteLine($"Product {product.Name} is not in warehouse");
            }*/

        }
        public void DelteWarehouse()
        {
            WarehouseCategories.Clear();
        }

        public override string ToString()
        {
            string res = $"Address {Address}";
            foreach (Category cat in WarehouseCategories)
            {
                res += cat.ToString();
                res += "\n";
            }
            return res;
        }
    }
}
