using System;

namespace ShopLogic.Models
{
    internal class SingleOrder
    {
        private int quantity;
        internal Product SingleProduct;
        internal int Quantity { get { return quantity; } set { quantity = value>=1?value:1;} }

        public SingleOrder(Product product, int quantity)
        {
            
            SingleProduct = product;
            this.quantity = quantity;
        }

        public void DecreaseQuantity()
        {
            if (quantity > 1)
            {
                quantity -= 1;
            }
            else
            {
                Console.WriteLine($"In your order quantity of {SingleProduct.Name} is already 1\nYou cant order less");
            }
        }
        public void IncreaseQuantity()
        {
            quantity += 1;
        }
    }
}
