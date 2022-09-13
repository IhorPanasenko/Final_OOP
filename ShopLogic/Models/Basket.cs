
using System.Collections.Generic;

namespace ShopLogic.Models
{
    internal class Basket
    {
        internal List<ProductInBasket> BasketOfProducts;

        public Basket()
        {
            BasketOfProducts = new List<ProductInBasket>();
        }
        
        public void AddProducts(Product product, int quantity)
        {
            if (!IsInBasket(product))
            {
                BasketOfProducts.Add(new ProductInBasket(product, quantity));
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
                foreach (ProductInBasket pr in BasketOfProducts)
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
                int number = BasketOfProducts.FindIndex((prod) => prod.SingleProduct.Name == product.Name);
                BasketOfProducts.RemoveAt(number);
            }
            else
            {
                Console.WriteLine("This product is not in Basket yet");
            }
        }

        public void ClearBasket()
        {
            BasketOfProducts.Clear();
        }

        public void DecreaseQuantity(Product product)
        {
            if (IsInBasket(product))
            {
                foreach (ProductInBasket pr in BasketOfProducts)
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
                foreach (ProductInBasket pr in BasketOfProducts)
                {
                    if (pr.SingleProduct.Name == product.Name)
                    {
                        if (pr.SingleProduct.TotalAmount >= pr.Quantity + 1)
                        {
                            pr.IncreaseQuantity();
                        }
                        else
                        {
                            Console.WriteLine("You want buy more than we have in warehouse");
                        }
                    }
                }
            }
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0m;
            foreach(ProductInBasket productInBasket in BasketOfProducts)
            {
                totalPrice += productInBasket.GetTotalPrice();
            }
            return totalPrice;
        }

        public void Buy()
        {
            foreach(ProductInBasket ProductInBasket in BasketOfProducts)
            {
                ProductInBasket.SingleProduct.TotalAmount -= ProductInBasket.Quantity;
            }
        }

        public override string ToString()
        {
            string res = "";
            foreach(ProductInBasket ProductInBasket in BasketOfProducts)
            {
                res+=ProductInBasket.ToString();
                res += "\n";
            }
            return res;
        }

        private bool IsInBasket(Product product)
        {
            bool IsIn = false;
            foreach(ProductInBasket pr in BasketOfProducts)
            {
                if(pr.SingleProduct.Name == product.Name)
                {
                    IsIn = true;
                    break;
                }
            }

            return IsIn;
        }
      /*  private int findPosition(Product product)
        {
            int counter = 0;
            foreach (ProductInBasket pr in BasketOfProducts)
            {
                if (pr.SingleProduct.Name == product.Name)
                {
                    break;
                }
                counter++;
            }
            return counter;
        }*/
    }
}
