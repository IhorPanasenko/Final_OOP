namespace ShopLogic
{
    internal interface IBuyable
    {
        public bool Buy(string DeliveryAddress);

        public void RegisterCreditCard(int NUmber, decimal Money);
    }
}
