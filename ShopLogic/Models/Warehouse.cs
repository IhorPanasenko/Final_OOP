
using System.Collections.Generic;

namespace ShopLogic.Models
{
    internal class Warehouse
    {
        public Product WarehouseProduct { get; set; }
        public int Quantity { get; set; }
        public string Adress { get; init; }

        public Warehouse(Product warehouseProduct, int quantity, string adress)
        {
            WarehouseProduct = warehouseProduct;
            Quantity = quantity;
            Adress = adress;
        }
    }
}
