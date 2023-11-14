using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Enemies.EnemyModels
{
    public interface IEnemyDamageTaker
    {
        public void TakeDamage(Enemy enemy, decimal amount);
    }
}
