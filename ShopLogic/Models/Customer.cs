
using ShopLogic.Interfaces;
using System;
using System.Reflection.Metadata.Ecma335;

namespace ShopLogic.Models
{
    internal class Customer : Person, IBuyable, ICustomerActions
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
        public bool UpdateQuantityOfProduct(Product product, int newQuantity)
        {
            if (newQuantity <= product.TotalAmount)
            {
                Basket.UpdateQuantityOfProduct(product, newQuantity);
                return true;
            }
            else
            {
                Console.WriteLine("You want to buy more than we have in warehouse");
                return false;
            }
           
        }
        public void RemoveFromBasket(Product product)
        {
            Basket.RemoveFromBasket(product);
        }
        public void IncreaseQuantityOfProduct(Product product)
        {
            Basket.IncreaseQuantity(product);
        }
        public void DecreaseQuantity(Product product)
        {
            Basket.DecreaseQuantity(product);
        }
        public string GetCheckByLastorder()
        {
            string res;
            if (Order != null)
            {
                res = Order.GetCheck();
            }
            else
            {
                res = "You havent bought anything yet";
            }
            //Console.WriteLine(res);
            return res;
        }
        public bool Buy(string deliveryAddress)
        {
            decimal price = Basket.GetTotalPrice();
            Order = new Order(DateTime.Today, Basket, this, price, deliveryAddress);
            if(CreditCard == null)
            {
                Console.WriteLine("You must register credit card before buying");
                return false;
            }
            else
            {
                if (CreditCard.Money<price)
                {
                    Basket.Buy();
                    Console.WriteLine("You havent got enough money to buy this products");
                    return false;
                }
                else
                {
                    Console.WriteLine("We got your payment");
                    //Basket.ClearBasket();
                    return true;
                }
            }
        }

        public string MyInfo()
        {
            string res =  $"Name: {First_name} {Last_name}\n Email: {this.EmailAdress}\nBirthfay Date {this.BirthDate}\n Login {Login} password: {Password}";
            if(CreditCard!= null)
            {
                res += $"\n CreditCard: { CreditCard}";   
            }
            else
            {
                res += "\nNo credit card info";
            }
            return res;
        }
        public string WatchBasket()
        {
            if (Basket != null)
            {
                return Basket.ToString();
            }
            else
            {
                return "No Basket info";
            }
        }

        public void UpdateInfo(string? login=null, string? password = null, string? first_name=null, string? last_name = null,  string? emailAdress = null)
        {
            Login = login != null ? login : Login;
            Password = password != null ? password : Password;
            First_name = first_name!= null ? first_name : First_name;
            Last_name = last_name!= null ? last_name : Last_name;
            EmailAdress = emailAdress != null ? emailAdress : EmailAdress;
        }

        public string WatchShopContent(E_shop e_shop)
        {
            return e_shop.WatchAsosrtiment();
        }
    }
}
