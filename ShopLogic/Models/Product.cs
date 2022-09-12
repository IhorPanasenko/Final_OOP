
namespace ShopLogic.Models
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalAmount { get; set; }
        public Category Category { get; set; }

        public Product(string name, string description, int totalAmount, Category category)
        {
            Name = name;
            Description = description;
            TotalAmount = totalAmount;
            Category = category;
        }
    }
}
