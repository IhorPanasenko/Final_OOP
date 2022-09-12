

namespace ShopLogic
{
    internal class Order
    {
        DateTime DateOfOrder { get; init; }
        Basket Basket { get; init; }
        Customer Customer { get; init; }


        internal Order(DateTime dateOfOrder, Basket basket, Customer customer)
        {
            DateOfOrder = dateOfOrder;
            Basket = basket;
            Customer = customer;
        }
    }
}
