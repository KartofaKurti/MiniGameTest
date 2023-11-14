using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Shop
{
    public class Shop
    {
        private Dictionary<string, int> items;

        public Shop()
        {
            items = new Dictionary<string, int>
            {
                {"HealthPot", 3 },

            };
        }

        public void BuyItem(Character character, string name, int itemCount)
        {
            if (items.ContainsKey(name))
            {
                int totalCost = items[name] * itemCount;
                if (character.Gold >= totalCost)
                {
                    character.CharacterDeductGold.DeductGold(character,totalCost);
                    character.Inventory.AddItem(name, itemCount);
                    Console.WriteLine($"Purchased {itemCount} {name}(s) from the shop for {totalCost} gold.");
                }
                else
                {
                    Console.WriteLine($"Insufficient gold! You need {totalCost - character.Gold} more gold.");
                }
            }
            else
            {
                Console.WriteLine($"Item {name} not available in the shop.");
            }
        }
        public void DisplayItems()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var kvp in items)
            {
                sb.AppendLine($"Item: {kvp.Key} \nCost: {kvp.Value}");
            }
            Console.WriteLine(sb.ToString());
        }

    }
}
