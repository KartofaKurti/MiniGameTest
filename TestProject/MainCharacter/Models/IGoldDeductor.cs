using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.MainCharacter.Models
{
    public interface IGoldDeductor
    {
        public void DeductGold(Character character, int amount);
    }
}
