
using System;

namespace ShopLogic.Models
{
    internal class Order
    {
        public DateTime DateOfOrder { get; init; }
        public Basket Basket { get; init; }
        public  Customer Customer { get; init; }
        public decimal TotalPrice { get; init; }

        public string DeliveryAddress { get; init; }

        public Order(DateTime dateOfOrder, Basket basket, Customer customer, decimal totalPrice, string deliveryAddress)
        {
            if (basket is null || customer is null)
                throw new ArgumentException("Basket and Customer cant be null");

            else if (String.IsNullOrEmpty(deliveryAddress))
                throw new ArgumentException("DeliveryAddress cant be null or empty");

            DateOfOrder = dateOfOrder;
            Basket = basket;
            Customer = customer;
            TotalPrice = totalPrice;
            DeliveryAddress = deliveryAddress;
        }

        public string GetCheck()
        {
            string check = $"{DateOfOrder} :date of order cofirmation\nYou buy on {TotalPrice}$ \nPayment was done buy card:{Customer.CreditCard}\nYou ordered: ";
            foreach (SingleOrder sOrder in Basket.BasketOfProduct)
            {
                check += $"\n{sOrder.SingleProduct.Name}\t*{sOrder.Quantity} = {sOrder.GetTotalPrice()}";
            }
            return check;
        }
    }
}
