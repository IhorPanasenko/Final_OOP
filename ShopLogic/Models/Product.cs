
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

        public void Delete()
        {
            Console.WriteLine($"product {Name} in category {Category.Name} was deleted");
            Name = "";
            Description = "";
            TotalAmount = -1;
            Category.DeleteCategory();
        }

       
    }
}
