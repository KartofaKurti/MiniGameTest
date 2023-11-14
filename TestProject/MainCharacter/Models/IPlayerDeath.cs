using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public interface ICharacterDeath
    {
        public void PlayerDeath(Character character);
    }
}
