using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Enemies;

namespace TestProject
{
    public class Zombie : Enemy
    {
        public Zombie(string name) : base(name, 100, 10, 100)
        {
        }

        public void ApplyBleed(Character character, Enemy enemy)
        {
            var dmgBleed = OnBleedDmg(enemy);
            try
            {
                var bleedRate = 2.5m;
                while (dmgBleed > 0)
                {
                    character.Health -= bleedRate - 0.1m;
                    Thread.Sleep(1000);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                dmgBleed = 0;
            }
        }

        private decimal OnBleedDmg(Enemy enemy)
        {
            var dmg = enemy.Level * 12 - (enemy.Level - 2);
            return dmg;
        }
    }
}
