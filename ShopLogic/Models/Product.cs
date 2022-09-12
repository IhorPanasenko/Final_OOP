

namespace ShopLogic
{
    internal class Product
    {
        string Name { get; set; }
        string Description { get; set; }
        int TotalAmount { get; set; }
        Category Category { get; set; }


        internal Product(string name, string description, int totalAmount, Category category)
        {
            Name = name;
            Description = description;
            TotalAmount = totalAmount;
            Category = category;
        }
    }
}
