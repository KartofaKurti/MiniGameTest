using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Items;
using TestProject.StartUp.Engine.Displayer;

namespace TestProject.MainCharacter.InventoryDetails
{
    public class Inventory
    {
        public Dictionary<string, int> InventoryID { get; set; }
        public IDisplayer Display;

        public Inventory()
        {
            InventoryID = new Dictionary<string, int>();
        }

        public void AddItem(string itemName, int itemCount)
        {
            if (!InventoryID.ContainsKey(itemName))
            {
                InventoryID[itemName] = itemCount;
            }
            else
            {
                InventoryID[itemName] += itemCount;
            }
        }

        public void RemoveItem(string itemName, int itemCount)
        {
            if (InventoryID.ContainsKey(itemName))
            {
                InventoryID[itemName] -= itemCount; // Remove specified count of the item

                if (InventoryID[itemName] <= 0)
                {
                    InventoryID.Remove(itemName); // If count is zero or negative, remove the item from the inventory
                }
            }
        }
        public int Count()
        {
            return InventoryID.Count;
        }

    }
}
