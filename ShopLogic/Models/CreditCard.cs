

using System.Globalization;
using System.Runtime.CompilerServices;

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

        public override string ToString()
        {
            if(this == null)
            {
                return string.Empty;
            }
            else
            {
                return $"Card Number: {Number}\n Money on Card: {Money}";
            }
        }
    }
}
