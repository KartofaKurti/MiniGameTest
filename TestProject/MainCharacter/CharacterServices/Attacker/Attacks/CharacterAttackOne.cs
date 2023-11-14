using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;

namespace TestProject.MainCharacter.CharacterServices.Attacker.Attacks
{
    public class CharacterAttackOne : IAttack
    {
        public decimal AbilityOneDamage(Character character)
        {
            decimal damageDealt = character.Damage * 2;
            return damageDealt;
        }

        public void Attack(Character character, Enemy enemy)
        {
            decimal damageDealt = AbilityOneDamage(character);
            enemy.EnemyDamageTaker.TakeDamage(enemy, damageDealt);
            Console.WriteLine($"Ability 1 dealt {damageDealt} damage to {enemy.Name}!");

        }
    }
}
