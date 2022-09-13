using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLogic.Models
{
    internal class E_shop
    {
        private List<Warehouse> warehouses;

        public List<Warehouse> Warehouses { get { return warehouses; } }
        public E_shop()
        {
            warehouses = new List<Warehouse>();
        }
        public void BringGoodsToTheStore()
        {
            Warehouse warehouseTechnick = new Warehouse("Kharkiv street 24");
            Warehouse warehouseFood = new Warehouse("Ivana Karkacha street 657");
            warehouses.Add(warehouseTechnick);
            warehouses.Add(warehouseFood);

            Category phones = new Category("Phones");
            Category Cars = new Category("Cars");
            Category MilkFood = new Category("Milk Food");
            Category Vegetables = new Category("Vegetables");
            warehouseTechnick.AddCategoryToWarehouse(phones);
            warehouseTechnick.AddCategoryToWarehouse(Cars);
            warehouseFood.AddCategoryToWarehouse(MilkFood);
            warehouseFood.AddCategoryToWarehouse(Vegetables);

            Product Iphone = new Product("Iphone 33", "Big phone without display", 255, 130000);
            Product Samsung = new Product("Samsung 52", "You can get our innovations right now", 140, 750000);
            Product Tesla = new Product("Tesla Y 10", "Our first car with nuclear Reator inside!!!!", 10, 999999999);
            Product Mercedes = new Product("Mercedes x666", "Ride diretly to hell with 1000000 horse strength", 2, 130000);
            Product Milk = new Product("Milk Ferma", "25% Milk", 10000, 40);
            Product Cheese = new Product("Old Cheese", "it is 100 years old", 400, 1000);
            Product Tomato = new Product("Tomato", "Fresh Tomatoes", 100000, 30);
            Product Cucumber = new Product("Cucumber", "Spanish Cucumber", 20000, 10);
            phones.AddProduct(Iphone);
            phones.AddProduct(Samsung);
            Cars.AddProduct(Tesla);
            Cars.AddProduct(Mercedes);
            MilkFood.AddProduct(Milk);
            MilkFood.AddProduct(Cheese);
            Vegetables.AddProduct(Tomato);
            Vegetables.AddProduct(Cucumber);

        }

        public void DeleteShop()
        {
            Warehouses.Clear();
        }

        public void AddWarehouse(Warehouse warehouse)
        {
            if (IsInShop(warehouse))
            {
                warehouses.Add(warehouse);
            }
            else
            {
                Console.WriteLine("This warehouse is already in shop");
            }
        }
        public void DeleteWarehouse(Warehouse warehouse)
        {
            if (IsInShop(warehouse))
            {
                int index = warehouses.IndexOf(warehouse);
                Warehouses.RemoveAt(index);
            }

        }

        public void PutProductInWarehouse(Warehouse warehouse, Category category, Product product)
        {
            if (!IsInShop(warehouse))
            {
                warehouses.Add(warehouse);
                warehouse.AdddProductToWarehouse(category, product);
            }
            else
            {
                warehouse.AdddProductToWarehouse(category, product);
            }
        }

        public string WatchAsosrtiment()
        {
            string res = "";
            foreach(Warehouse warehouse in warehouses)
            {
                res += warehouse.ToString();
                res += "\n";
            }
            return res;
        }
        private bool IsInShop(Warehouse warehouse)
        { 
            bool IsIn = false;
            foreach (Warehouse whouse in Warehouses)
            {
                if (whouse.Address == warehouse.Address)
                {
                    IsIn = true;
                    break;
                }
            }

            return IsIn;
        }
    }
}
