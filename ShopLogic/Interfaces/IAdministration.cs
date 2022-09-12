namespace ShopLogic.Interfaces
{
    internal interface IAdministration
    {
        public Category CrateCategory();
        public void DeleteCategory();
        public void UpdateCategory();
        public void CreateProduct();
        public void DeleteProduct();
        public void UpdateProduct();
        
    }
}
