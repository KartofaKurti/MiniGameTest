using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Enemies.EnemyModels;

namespace TestProject.MainCharacter.CharacterServices.LeverServices
{
    public class LevelUpper 
    {
        public void CheckXp(Character data)
        {
            int diff = 0;
            if (data.Xp >= 100)
            {
                diff = data.Xp - 100;
                data.Xp = diff;
                data.Level++;
                Console.WriteLine($"You are now Level {data.Level}!");
                GetRewards(data);
            }
        }

        private void GetRewards(Character data)
        {
            data.Rewards.ChooseStatToUpgrade(data);
        }
    }
}
