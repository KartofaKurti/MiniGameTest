using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.StartUp.Engine;

namespace TestProject.MainCharacter.CharacterServices.LeverServices
{
    public class CharacterLevelUpReward
    {
        public void ChooseStatToUpgrade(Character character)
        {
            Console.WriteLine("If you want to increase your maxHp type 1 \n" +
                              "If you want to increase your Damage type 2" +
                              "Enjoy!");
            var input = new Inputer().PlayerInput();
            switch (input)
            {
                case "1":
                    IncreaseHp(character);
                    break;
                case "2":
                    IncreaseDmg(character);
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }

        private void IncreaseDmg(Character character)
        {
            var bonusDmg = character.Damage * 0.05m;
            character.Damage += bonusDmg;
        }

        private void IncreaseHp(Character character)
        {
            var bonusHp = character.Health * 0.10m;
            character.MaxCharacterHp += bonusHp;
        }
    }
}
