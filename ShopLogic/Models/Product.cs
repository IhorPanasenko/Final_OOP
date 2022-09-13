
namespace ShopLogic.Models
{
    internal class Product
    {
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal int TotalAmount { get; set; }
        internal string Category { get; set; }
        internal int Price { get; set; }

        public Product(string name, string description ,int totalAmount, string category, int price)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(description))
                throw new ArgumentException("Name and Description cant be null or empty");

            else if (totalAmount < 0 || price < 0)
                throw new ArgumentException("TotalAmount and Price cant be less then zero");

            else if (category is null)
                throw new ArgumentException("Category cant be null");

            Name = name;
            Description = description;
            TotalAmount = totalAmount;
            Category = category;
            Price = price;
        }

        public void Delete()
        {
            Console.WriteLine($"product {Name} in category {Category} was deleted");
            Name = "";
            Description = "";
            Category = "";
            TotalAmount = -1;
            Price = -1;
        }

       public void Update(string? name = null, string? description = null, int totalAmount = -1, string? category = null, int price=-1)
        {
            Name = name != null ? name : Name;
            Description = description != null ? description : Description;
            TotalAmount = totalAmount > 0 ? totalAmount : TotalAmount;
            Category = category != null ? category : Category;
            Price = price > 0 ? price : 1;
        }

        public override string ToString()
        {
            return $"Product:\n {Name}\nIn category {Category}\n{Description}\nTotal amount: {TotalAmount}\nPrice {Price}";
        }
    }
}
