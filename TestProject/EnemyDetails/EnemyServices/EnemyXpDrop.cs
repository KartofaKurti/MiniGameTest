using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.EnemyDetails.EnemyModels;

namespace TestProject.EnemyDetails.EnemyServices
{
    public class EnemyXpDrop : IXpDropper
    {
        public void GiveXp(Character character, Enemy enemy)
        {
            int xp = GetXpReward(enemy);
            character.Xp += xp;
        }
        private int GetXpReward(Enemy enemy)
        {
            int rewards = (int)(enemy.Health * 0.1m + enemy.Damage * 0.25m);
            return rewards;
        }

    }

}
