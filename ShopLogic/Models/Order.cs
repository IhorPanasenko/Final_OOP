
using System;

namespace ShopLogic.Models
{
    internal class Order
    {
        public DateTime DateOfOrder { get; init; }
        public Basket Basket { get; init; }
      //  public  Customer Customer { get; init; }


        public Order(DateTime dateOfOrder, Basket basket, Customer customer)
        {
            DateOfOrder = dateOfOrder;
            Basket = basket;
            Customer = customer;
        }
    }
}
