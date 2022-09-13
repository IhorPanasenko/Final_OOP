

namespace ShopLogic.Models
{
    internal class CreditCard
    {
        public int Number { get; set; }
        public decimal Money { get; set; }


        public CreditCard(int number, decimal money)
        {
            Number = number;
            Money = money;
        }

    }
}
