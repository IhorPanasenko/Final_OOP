using ShopLogic.Models;
using System.Net;

namespace ShopLogic.Interfaces
{
    internal interface IAdministration
    {
        public Category CrateCategory(string Name);

        public void DeleteCategory(Warehouse waerhouse, Category category);

        public void UpdateCategory(Category category, string newName);

        public Product CreateProduct(string name, string description, int totalAmount, int price);

        public void DeleteProduct(Category category, Product product);

        public void UpdateProduct(Product product, string? name=null, string? description=null, int totalAmount=-1, int price = -1);

        public void PutProductInShop(E_shop shop, Warehouse warehouse, Category category, Product product);

    }
}
