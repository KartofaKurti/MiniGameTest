using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Enemies.EnemyModels;
using TestProject.Enemies.Services;
using TestProject.EnemyDetails.EnemyModels;
using TestProject.EnemyDetails.EnemyServices;
using TestProject.Models;

namespace TestProject
{
    public class Enemy : IEnemyDeath,ILevelUpper
    {
        public string Name { get; private set; }
        public int Level { get; private set; }


        private decimal _Damage;
        public decimal Damage
        {
            get { return _Damage; }
            set { _Damage = value; }
        }


        public decimal BaseHp;
        private decimal _Health;
        public decimal Health
        {
            get { return _Health; }
            set { _Health = value; }
        }
        

        public IEnemyDamageTaker EnemyDamageTaker;
        public IAttack EnemyAttacker;
        public IGoldCalculator EnemyGoldCalculator;
        public IXpDropper EnemyXpDrop;


        public Enemy(string name, decimal health, decimal damage,decimal baseHp)
        {
            Name = name;
            Health = health;
            Damage = damage;
            BaseHp = baseHp;
            Level = 1;
            EnemyDamageTaker = new EnemyDamageTaker();
            EnemyAttacker = new EnemyAttacker();
            EnemyGoldCalculator = new EnemyGoldCalculator();
            EnemyXpDrop = new EnemyXpDrop();
        }

        public void LevelUp(Enemy enemy)
        {
            _Health += (_Health * 0.20m);
            _Damage += (_Damage * 0.10m);
            Level += 1;
        }

        public void Die(Enemy enemy)
        {
            Console.WriteLine($"You have defeated {enemy.Name}!");
        }
        public void Kill(Enemy enemy)
        {
            enemy._Health = 0;
        }
    }
}
