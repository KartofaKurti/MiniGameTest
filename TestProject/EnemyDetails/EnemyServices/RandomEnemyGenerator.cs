using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Enemies
{
    public class RandomEnemyGenerator
    {
        public Enemy GenerateRandomEnemy()
        {
            string[] possibleNames = { "Gromp", "Zombie" };
            Random random = new Random();
            string randomName = possibleNames[random.Next(possibleNames.Length)];

            switch (randomName)
            {
                case "Gromp":
                    return new Gromp(randomName);
                case "Zombie":
                    return new Zombie(randomName);
                default:
                    return new Enemy(randomName, 0, 0,0);
            }
        }
    }
}
