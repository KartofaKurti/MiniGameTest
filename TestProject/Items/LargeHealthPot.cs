using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Items
{
    public class LargeHealthPot
    {
        public string Name { get; private set; }
        public int HealingAmount { get; private set; }

        public LargeHealthPot()
        {
            Name = "LargeHealthPot";
            HealingAmount = 38;
        }

        public void Use(Character character)
        {
            if (character.Health == character.MaxCharacterHp)
            {
                Console.WriteLine("You are already at full health. The Health Pot had no effect.");
            }
            else
            {
                character.CharacterHeal.Heal(character, HealingAmount);
            }
        }
    }
}
