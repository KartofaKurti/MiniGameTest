using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;

namespace TestProject.Enemies.Services
{
    public class EnemyAttacker : IAttack
    {
        public void Attack(Character character, Enemy enemy)
        {
            character.Health -= enemy.Damage;
        }
    }
}
