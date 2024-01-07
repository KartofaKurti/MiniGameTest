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
            {
                var dmgBleed = OnBleedDmg(enemy);

                var bleedRate = 2.5m;
                while (dmgBleed > 0)
                {
                    character.Health -= bleedRate - 0.1m;
                    bleedRate -= 0.1m;
                    dmgBleed -= bleedRate;
                    Console.WriteLine(bleedRate);
                    Thread.Sleep(1000);
                }
                if (dmgBleed < 0)
                {
                    character.Health += Math.Abs(dmgBleed);
                }
            }
        }

        private decimal OnBleedDmg(Enemy enemy)
        {
            var dmg = enemy.Level * 12 - (enemy.Level - 2);
            return dmg;
        }
    }
}
