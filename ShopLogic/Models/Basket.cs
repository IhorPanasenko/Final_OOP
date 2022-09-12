
using System.Collections.Generic;

namespace ShopLogic.Models
{
    internal class Basket
    {
        public List<Product> basketOfProduct;
        public int Quantity { get; set; }

        public Basket(List<Product> basketOfProduct, int quantity)
        {
            this.basketOfProduct = basketOfProduct;
            Quantity = quantity;
        }
    }
}
