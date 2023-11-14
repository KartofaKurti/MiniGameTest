using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Enemies;

namespace TestProject
{
    public class Gromp : Enemy
    {
        public decimal BaseHp = 150;
        public Gromp(string name) : base(name, 150, 15, 150) // Set initial health to 150 and damage to 15 for Gromp
        {
        }
        /*
        public void ReduceDmgTaken(decimal dmg)
        {
            var reducedDmg = dmg - (dmg * 0.10m);
            EnemyDamageTaker.TakeDamage(reducedDmg);
        }
        */
    }
}
