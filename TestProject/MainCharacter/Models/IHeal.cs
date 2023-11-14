using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public interface IHeal
    {
        public void Heal(Character character, decimal amount);
    }
}
