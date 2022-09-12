
using System;

namespace ShopLogic.Models
{
    internal class Customer : Person, IBuyable
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateOfRegistration { get; init; }
        public CreditCard? CreditCard { get; set; }
        public Order? Order {get; set;}
        public Basket Basket { get; set; }

        public Customer(string login, string password, DateTime dateOfRegistration, string first_name, string last_name, DateTime birthDate, string emailAdress)
            : base(first_name, last_name, birthDate, emailAdress)
        {
            Login = login;
            Password = password;
            DateOfRegistration = dateOfRegistration;
            Basket = new Basket();
        }
        
        public void RegisterCreditCard(int Number, decimal Money)
        {
            CreditCard = new CreditCard(Number, Money);
        }

        public bool AddProductToBasket(Product product, int quantity)
        {
            if (quantity <= product.TotalAmount)
            {
                Basket.AddProducts(product, quantity);
                return true;
            }
            else
            {
                Console.WriteLine("You want to buy more than we have in warehouse");
                return false;
            }
        }
        public void ClearBasket()
        {
            Basket.ClearBasket();
        }

        

        public void Buy()
        {
            throw new NotImplementedException();
        }
    }
}
