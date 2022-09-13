
using System;

namespace ShopLogic.Models
{
    internal abstract class Person
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public DateTime BirthDate { get; init; }
        public string EmailAdress { get; set; }


        public Person(string first_name, string last_name, DateTime birthDate, string emailAdress)
        { 
            First_name = first_name;
            Last_name = last_name;
            BirthDate = birthDate;
            EmailAdress = emailAdress;
        }
    }
}
