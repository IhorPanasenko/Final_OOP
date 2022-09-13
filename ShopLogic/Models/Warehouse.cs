
using System.Collections.Generic;

namespace ShopLogic.Models
{
    internal class Warehouse
    {
        public List<Product> WarehouseProduct { get; set; }
        public string Adress { get; init; }

        public Warehouse(string adress)
        {
            WarehouseProduct = new List<Product>();
            Adress = adress;
        }

    }
}
