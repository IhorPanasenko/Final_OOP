namespace ShopLogic
{
    internal interface IBuyable
    {
        public void Buy();

        public void RegisterCreditCard(int NUmber, decimal Money);
    }
}
