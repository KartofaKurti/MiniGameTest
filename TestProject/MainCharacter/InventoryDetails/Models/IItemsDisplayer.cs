using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.MainCharacter.InventoryDetails;

namespace TestProject.MainCharacter.InventoryDetails.Models
{
    public interface IItemsDisplayer
    {
        public void DisplayItems(Character inventory);
    }
}
