using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.TestCharacter.Models;

namespace TestProject.TestCharacter.CharacterServices
{
    public class CharacterDamageTaker : IDamagetaker
    {
        public void TakeDamage(Character character, Enemy enemy)
        {
            character.Health -= enemy.Damage;
        }
    }
}
