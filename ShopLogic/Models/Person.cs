
using System;

namespace ShopLogic
{
    internal abstract class Person
    {
        string First_name { get; set; }
        string Last_name { get; set; }
        DateTime BirthDate { get; init; }
        string EmailAdress { get; set; }


        internal Person(string first_name, string last_name, DateTime birthDate, string emailAdress)
        {
            First_name = first_name;
            Last_name = last_name;
            BirthDate = birthDate;
            EmailAdress = emailAdress;
        }
    }
}
