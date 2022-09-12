
using System.Collections.Generic;

namespace ShopLogic.Models
{
    internal class Basket
    {
        internal List<SingleOrder> BasketOfProduct;

        public Basket()
        {
            BasketOfProduct = new List<SingleOrder>();
        }
        
        public void AddProducts(Product product, int quantity)
        {
            BasketOfProduct.Add(new SingleOrder(product, quantity));
        }

    }
}
