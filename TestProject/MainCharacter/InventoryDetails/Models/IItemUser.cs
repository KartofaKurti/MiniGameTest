using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.MainCharacter.InventoryDetails.Models
{
    public interface IItemUser
    {
        public void UseItem(object item, Character character);
    }
}
