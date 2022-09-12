
using System.Collections.Generic;

namespace ShopLogic.Models
{
    internal class Warehouse
    {
        public List<Product> warehouseProducts;
        public int Quantity { get; set; }
        public string Adress { get; init; }

        public Warehouse(List<Product> warehouseProducts, int quantity, string adress)
        {
            this.warehouseProducts = warehouseProducts;
            Quantity = quantity;
            Adress = adress;
        }
    }
}
