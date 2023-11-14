using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Enemies.EnemyModels;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject.Enemies.Services
{
    public class EnemyGoldCalculator : IGoldCalculator
    {
        public void CalculateGold(Character character, Enemy enemy)
        {
            enemy.Health = enemy.BaseHp;
            decimal rewards = (enemy.Health * 0.1m + enemy.Damage * 0.1m) / 2;
            decimal baseReward = 10 + rewards;
            character.Gold += baseReward;
        }

    }
}
