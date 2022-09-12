
namespace ShopLogic.Models
{
    internal class Product
    {
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal int TotalAmount { get; set; }
        internal Category Category { get; set; }
        internal int Price { get; set; }

        public Product(string name, string description, int totalAmount, Category category, int price)
        {
            Name = name;
            Description = description;
            TotalAmount = totalAmount;
            Category = category;
            Price = price;
        }

        public void Delete()
        {
            Console.WriteLine($"product {Name} in category {Category.Name} was deleted");
            Name = "";
            Description = "";
            TotalAmount = -1;
            Category.DeleteCategory();
            Price = -1;
        }

       public void Update(string? name = null, string? description = null, int totalAmount = -1, Category? category = null, int price=-1)
        {
            Name = name != null ? name : Name;
            Description = description != null ? description : Description;
            TotalAmount = totalAmount > 0 ? totalAmount : TotalAmount;
            Category = category != null ? category : Category;
            Price = price > 0 ? price : 1;
        }
    }
}
