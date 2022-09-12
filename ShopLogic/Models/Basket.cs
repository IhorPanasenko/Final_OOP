

namespace ShopLogic
{
    internal class Basket
    {
        List<Product> basketOfProduct;
        int Quantity { get; set; }

        
        internal Basket(List<Product> basketOfProduct, int quantity)
        {
            this.basketOfProduct = basketOfProduct;
            Quantity = quantity;
        }
    }
}
