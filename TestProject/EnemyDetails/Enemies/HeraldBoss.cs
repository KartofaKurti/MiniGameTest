using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.EnemyDetails.Enemies
{
    internal class HeraldBoss : Enemy
    {
        public HeraldBoss(string name, decimal health, decimal damage, decimal baseHp) : base(name, health, damage, baseHp)
        {
            name = "Herald";
            health = 300;
            baseHp = 300;
            damage = 20;
        }

        public void HeraldAttack(Character character)
        {
            character.Health -= Damage;
        }

        public void EyeHit(Character character)
        {
            Health -= character.Damage * 2;
        }

    }
}
