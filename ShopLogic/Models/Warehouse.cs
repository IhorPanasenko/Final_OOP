

namespace ShopLogic
{
    internal class Warehouse
    {
        List<Product> warehouseProducts;
        int Quantity { get; set; }
        string Adress { get; init; }


        internal Warehouse(List<Product> warehouseProducts, int quantity, string adress)
        {
            this.warehouseProducts = warehouseProducts;
            Quantity = quantity;
            Adress = adress;
        }
    }
}
