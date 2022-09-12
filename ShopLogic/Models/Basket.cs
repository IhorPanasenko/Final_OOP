
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
            if (!IsInBasket(product))
            {
                BasketOfProduct.Add(new SingleOrder(product, quantity));
            }
            else
            {
                Console.WriteLine($"product {product.Name} already in basket, quantity was updated");
                UpdateQuantityOfProduct(product, quantity);

            }
        }

        public void UpdateQuantityOfProduct(Product product, int newQuantity)
        {
            if (IsInBasket(product))
            {
                foreach (SingleOrder pr in BasketOfProduct)
                {
                    if (pr.SingleProduct.Name == product.Name)
                    {
                        pr.UpdateQuantity(newQuantity);
                    }
                }
            }
        }

        private bool IsInBasket(Product product)
        {
            bool IsIn = false;
            foreach(SingleOrder pr in BasketOfProduct)
            {
                if(pr.SingleProduct.Name == product.Name)
                {
                    IsIn = true;
                    break;
                }
            }

            return IsIn;
        }
    }
}
