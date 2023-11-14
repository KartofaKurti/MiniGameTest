using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;

namespace TestProject.TestCharacter.CharacterServices
{
    public class CharacterHeal : IHeal
    {
        public void Heal(Character character, decimal amount)
        {
            decimal healedAmount = character.Health - amount;
            Console.WriteLine($"Used Health Pot and healed {healedAmount} HP!");

            if (character.Health > character.MaxCharacterHp)
            {
                character.Health = character.MaxCharacterHp; 
            }
        }
    }
}
