using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Enemies.EnemyModels
{
    public interface IGoldCalculator
    {
        public void CalculateGold(Character character, Enemy enemy);
    }
}
