

using System.Globalization;
using System.Runtime.CompilerServices;

namespace ShopLogic.Models
{
    internal class CreditCard
    {
        public int? Number { get; set; }
        public decimal? Money { get; set; }


        public CreditCard(int? number, decimal? money)
        {
            if (number is null || money is null)
                throw new ArgumentException("Number and money cant be null");
            
            else if (money < 0)
                throw new ArgumentException("Count of money on card cant be less than zero");
            
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
