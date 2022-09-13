using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLogic.Models
{
    internal class E_shop
    {
        private List<Warehouse> warehouses; //{ get; set;}

        public List<Warehouse> Warehouses { get { return warehouses; } }
        public E_shop()
        {
            warehouses = new List<Warehouse>();
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
                int position = FindWarehousePosition(warehouse);
                Warehouses.RemoveAt(position);
            }

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
        private int FindWarehousePosition(Warehouse warehouse)
        {
            int counter = 0;
            foreach (Warehouse whouse in Warehouses)
            {
                if (whouse.Address == warehouse.Address)
                {
                    break;
                }
                counter++;
            }

            return counter;
        }


    }
}
