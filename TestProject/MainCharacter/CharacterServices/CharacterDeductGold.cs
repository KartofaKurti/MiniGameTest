using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.MainCharacter.Models;

namespace TestProject.TestCharacter.CharacterServices
{
    public class CharacterDeductGold : IGoldDeductor
    {
        public void DeductGold(Character character,int amount)
        {
            if (character.Gold >= amount)
            {
                character.Gold -= amount;
            }
            else
            {
                Console.WriteLine($"Insufficient gold! You need {amount - character.Gold} more gold.");
            }
        }
    }
}
