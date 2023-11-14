using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TestProject.Enemies;

namespace TestProject
{
    public class Character : Inventory 
    {
        private const decimal DefaultCharacterHp = 100;
        public string Name { get; private set; }
        public decimal Health { get; private set; }
        public decimal Damage { get; private set; }
        public Inventory Inventory { get; private set; }
        public decimal Gold { get; set; }

        

        public decimal _Health
        {
            get { return Health; }
            set { Health = value; }
        }

        public Character(string name)
        {
            this.Name = name;
            this.Health = 100;
            this.Damage = 11;
            this.Gold = 3;
            Inventory = new Inventory();
        }

        public void Heal(decimal amount)
        {
            decimal healedAmount = Health - amount;
            Console.WriteLine($"Used Health Pot and healed {healedAmount} HP!");

            if (Health > DefaultCharacterHp)
            {
                Health = 100; // Set health to max
            }
        }
        public void DeductGold(int amount)
        {
            if (Gold >= amount)
            {
                Gold -= amount;
            }
            else
            {
                Console.WriteLine($"Insufficient gold! You need {amount - Gold} more gold.");
            }
        }

        public void RemoveHealth(decimal amount)
        {
            Health -= amount;
        }

        public bool IsCharacterDeath(Character character)
        {
            if (character.Health <= 0)
            {
                return true;
            }
            return false;
        }

        public void KillYourSelf(Character character)
        {
            Health = 0;
        }

        public void Emote()
        {
            Console.WriteLine($"{Name} is dancing!");
        }
    }
}
