using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TestProject.Enemies;
using TestProject.MainCharacter.CharacterServices;
using TestProject.MainCharacter.InventoryDetails;
using TestProject.MainCharacter.InventoryDetails.InventoryServices;
using TestProject.MainCharacter.InventoryDetails.Models;
using TestProject.MainCharacter.Models;
using TestProject.Models;
using TestProject.TestCharacter.CharacterServices;
using TestProject.TestCharacter.Models;

namespace TestProject
{
    public class Character : ICharacterDeath
    {
        public string Name { get; private set; }

        public decimal MaxCharacterHp = 100;
        private decimal _Health;
        public decimal Health
        {
            get { return _Health; }
            set { _Health = value; }
        }


        private decimal _Damage;
        public decimal Damage
        {
            get { return _Damage; }
            set { _Damage = value; }
        }

        public Inventory Inventory { get; private set; }

        public decimal Gold { get; set; }
        public int Level { get; private set; }
        
        public IGoldDeductor CharacterDeductGold;
        public IHeal CharacterHeal;
        public IDamagetaker CharacterDamageTaker;
        public IItemsDisplayer Items;
        public IItemUser UseItem { get; set; }
        public IAttack Attack { get; set; }
        
        public Character(string name)
        {
            this.Name = name;
            this.Health = 100;
            this.Damage = 11;
            this.Gold = 3;
            Inventory = new Inventory();
            this.Level = 1;
            CharacterDeductGold = new CharacterDeductGold();
            CharacterHeal = new CharacterHeal();
            CharacterDamageTaker = new CharacterDamageTaker();
            Items = new ItemsDisplayer();
        }

        public void GoAttack(Character character, Enemy enemy)
        {
            Attack.Attack(character, enemy);
        }
        public bool IsCharacterDeath(Character character)
        {
            if (character.Health <= 0)
            {
                return true;
            }
            return false;
        }

        public void KillYourSelf()
        {
            _Health = 0;
        }

        public void Emote()
        {
            Console.WriteLine($"{Name} is dancing!");
        }

        public void PlayerDeath(Character character)
        {
            Console.WriteLine("You died trash!");
        }
    }
}
