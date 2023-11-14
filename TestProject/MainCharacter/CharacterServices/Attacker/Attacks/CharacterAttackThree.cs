using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;

namespace TestProject.MainCharacter.CharacterServices.Attacker.Attacks
{
    public class CharacterAttackThree : IAttack
    {
        public decimal AbilityThree(Character character)
        {
            decimal damageDealt = character.Damage * 3;
            return damageDealt;
        }

        public void Attack(Character character, Enemy enemy)
        {
            decimal damageDealt = AbilityThree(character);
            enemy.EnemyDamageTaker.TakeDamage(enemy, damageDealt);
            Console.WriteLine($"Ability 3 dealt {damageDealt} damage to {enemy.Name}!");

        }
    }
}
