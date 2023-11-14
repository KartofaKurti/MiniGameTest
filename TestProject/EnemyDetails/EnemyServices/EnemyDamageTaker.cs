using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Enemies.EnemyModels;

namespace TestProject.Enemies.Services
{
    public class EnemyDamageTaker : IEnemyDamageTaker
    {
        public void TakeDamage(Enemy enemy, decimal amount)
        {
            enemy.Health -= amount;
        }
    }
}
