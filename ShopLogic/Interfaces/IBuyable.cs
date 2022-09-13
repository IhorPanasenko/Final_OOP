using ShopLogic.Models;

namespace ShopLogic
{
    internal interface IBuyable
    {
        public void RegisterCreditCard(int Number, decimal Money);

        public bool AddProductToBasket(Product product, int quantity);

        public void ClearBasket();

        public bool UpdateQuantityOfProduct(Product product, int newQuantity);

        public void RemoveFromBasket(Product product);

        public void IncreaseQuantityOfProduct(Product product);

        public void DecreaseQuantity(Product product);

        public string GetCheckByLastorder();

        public bool Buy(string deliveryAddress);

    }
}
