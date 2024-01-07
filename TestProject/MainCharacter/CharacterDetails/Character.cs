using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TestProject.Enemies;
using TestProject.MainCharacter.CharacterServices;
using TestProject.MainCharacter.CharacterServices.LeverServices;
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
        private string name;
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name must not be null.");
                }
                name = value;
            }
        }

        private decimal maxCharacterHp;
        public decimal MaxCharacterHp
        {
            get { return maxCharacterHp; }
            set => maxCharacterHp = value;
        }

        private decimal health;
        public decimal Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Health must be positive number.");
                }
                health = value;
            }
        }

        private int xp;
        public int Xp
        {
            get { return xp; }
            set { xp = value; }
        }

        public int Level { get; set; }

        private decimal damage;
        public decimal Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        private decimal gold;
        public decimal Gold
        {
            get => gold;
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Gold must be positive number or 0.");
                }
                gold = value;
            }
        }

        public Inventory Inventory { get; private set; }

        public IGoldDeductor CharacterDeductGold;
        public IHeal CharacterHeal;
        public IDamagetaker CharacterDamageTaker;
        public IItemsDisplayer Items;
        public IItemUser UseItem { get; set; }
        public IAttack Attack { get; set; }
        public LevelUpper LevelUp { get; private set; }

        public CharacterLevelUpReward Rewards { get; private set; }

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
            LevelUp = new LevelUpper();
            MaxCharacterHp = 100;
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
            health = 0;
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
