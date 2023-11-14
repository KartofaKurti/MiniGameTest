using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.MainCharacter.InventoryDetails.Models;

namespace TestProject.MainCharacter.InventoryDetails.InventoryServices
{
    public class ItemsDisplayer : IItemsDisplayer
    {
        public void DisplayItems(Character character)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Items:");
            if (character.Inventory.Count() > 0)
            {
                foreach (var kvp in character.Inventory.InventoryID)
                {
                    sb.AppendLine($"Item: {kvp.Key} - {kvp.Value}");
                }
            }
            else
            {
                sb.AppendLine("No items!");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
