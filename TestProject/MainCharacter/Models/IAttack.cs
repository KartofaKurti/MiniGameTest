using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Enemies;

namespace TestProject.Models
{
    public interface IAttack
    {
        public void Attack(Character character,Enemy enemy);
    }
}
