using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;

namespace TestProject.MainCharacter.CharacterServices.Attacker.Attacks
{
    public class CharacterAttackTwo : IAttack
    {
        public decimal AbilityTwo(Character character)
        {
            decimal damageDealt = character.Damage * 2.2m;
            return damageDealt;
        }

        public void Attack(Character character, Enemy enemy)
        {
            decimal damageDealt = AbilityTwo(character);
            enemy.EnemyDamageTaker.TakeDamage(enemy, damageDealt);
            Console.WriteLine($"Ability 2 dealt {damageDealt} damage to {enemy.Name}!");

        }
    }
}
