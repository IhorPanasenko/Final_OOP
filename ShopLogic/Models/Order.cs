
using System;

namespace ShopLogic.Models
{
    internal class Order
    {
        public DateTime DateOfOrder { get; init; }
        public Basket Basket { get; init; }
        public  Customer Customer { get; init; }
        public decimal TotalPrice { get; init; }


        public Order(DateTime dateOfOrder, Basket basket, Customer customer, int totalPrice)
        {
            DateOfOrder = dateOfOrder;
            Basket = basket;
            Customer = customer;
            TotalPrice = totalPrice;
        }
    }
}
