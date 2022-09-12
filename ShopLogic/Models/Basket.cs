﻿
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
            else
            {
                Console.WriteLine("This product is not in Basket yet");
            }
        }

        public void RemoveFromBasket(Product product)
        {
            if (IsInBasket(product))
            {
                int number = findPosition(product);
                BasketOfProduct.RemoveAt(number);
            }
            else
            {
                Console.WriteLine("This product is not in Basket yet");
            }
        }

        public void ClearBasket()
        {
            BasketOfProduct.Clear();
        }

        public void DecreaseQuantity(Product product)
        {
            if (IsInBasket(product))
            {
                foreach (SingleOrder pr in BasketOfProduct)
                {
                    if (pr.SingleProduct.Name == product.Name)
                    {
                        pr.DecreaseQuantity();
                    }
                }
            }
        }
        public void IncreaseQuantity(Product product)
        {
            if (IsInBasket(product))
            {
                foreach (SingleOrder pr in BasketOfProduct)
                {
                    if (pr.SingleProduct.Name == product.Name)
                    {
                        pr.IncreaseQuantity();
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
        private int findPosition(Product product)
        {
            int counter = 0;
            foreach (SingleOrder pr in BasketOfProduct)
            {
                if (pr.SingleProduct.Name == product.Name)
                {
                    break;
                }
                counter++;
            }
            return counter;
        }
    }
}
