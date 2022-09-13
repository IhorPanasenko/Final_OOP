
using System.Collections.Generic;

namespace ShopLogic.Models
{
    internal class Warehouse
    {
        public List<Product> WarehouseProduct { get; set; }
        public string Address { get; set; }

        public Warehouse(string adress)
        {
            WarehouseProduct = new List<Product>();
            Address = adress;
        }
        public void PutProductToWarehouse(Product product)
        {
            WarehouseProduct.Add(product);
        }

        public void ChangeWarehouseAddress(string address)
        {
            Address = address != null ? address : Address;
        }

    }
}
