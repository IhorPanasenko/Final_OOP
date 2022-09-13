
using System.Collections.Generic;

namespace ShopLogic.Models
{
    internal class Warehouse
    {
        public List<Product> WarehouseProduct { get; set; }
        public string Address { get; set; }

        public Warehouse(string adress)
        {
            WarehouseProduct = new List<Product>();
            Address = adress;
        }
        public void PutProductToWarehouse(Product product)
        {
            WarehouseProduct.Add(product);
        }

        public void ChangeWarehouseAddress(string address)
        {
            Address = address != null ? address : Address;
        }

        public void DeleteProductFromWarehouse(Product product)
        {
            if (IsInWarehouse(product)){
                int position = FindProductPosition(product);
                WarehouseProduct.RemoveAt(position);
            }
            else
            {
                Console.WriteLine($"Product {product.Name} is not in warehouse");
            }

        }
        public void DelteWarehouse()
        {
            WarehouseProduct.Clear();
        }

        public void DeleteProductsWithZeroQuantity()
        {
            foreach (Product pr in WarehouseProduct)
            {
                if(pr.TotalAmount == 0)
                {
                    DeleteProductFromWarehouse(pr);
                }
            }
        }

        public override string ToString()
        {
            string res = $"Address {Address}";
            foreach (Product pr in WarehouseProduct)
            {
                res += pr.ToString();
                res += "\n";
            }
            return res;
        }

        private bool IsInWarehouse(Product product)
        {
            bool IsIn = false;
            foreach (Product pr in WarehouseProduct)
            {
                if (pr.Name == product.Name)
                {
                    IsIn = true;
                    break;
                }
            }

            return IsIn;
        }
        private int FindProductPosition(Product product)
        {
            int counter = 0;
            foreach (Product pr in WarehouseProduct)
            {
                if (pr.Name == product.Name)
                {
                    break;
                }
                counter++;
            }

            return counter;
        }

    }
}
