

namespace ShopLogic
{
    internal class CreditCard
    {
        int Number { get; set; }
        decimal Money { get; set; }


        internal CreditCard(int number, decimal money)
        {
            Number = number;
            Money = money;
        }

    }
}
