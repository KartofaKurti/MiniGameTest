using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.TestCharacter.Models
{
    public interface IDamagetaker
    {
        public void TakeDamage(Character character, Enemy enemy);
    }
}
