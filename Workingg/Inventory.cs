using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Inventory 
    {
        private Dictionary<string,int> InventoryID { get; set; }

        public Inventory()
        {
            this.InventoryID = new Dictionary<string,int>();
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

        public string OpenInvetory()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Items:");
            if (InventoryID.Count > 0)
            {
                foreach (var kvp in InventoryID)
                {
                    sb.AppendLine($"Item: {kvp.Key} - {kvp.Value}");
                }
            }
            else
            {
                sb.AppendLine("No items!");
            }

            return sb.ToString();
        }
        public bool UseItem(string itemName, Character character)
        {
            if (InventoryID.ContainsKey(itemName))
            {
                if (itemName == "HealthPot")
                {
                    HealthPot healthPot = new HealthPot(); 
                    healthPot.Use(character);
                }
                RemoveItem(itemName, 1);
                return true;
            }

            Console.WriteLine("Item not found in inventory.");
            return false;
        }

    }
}
