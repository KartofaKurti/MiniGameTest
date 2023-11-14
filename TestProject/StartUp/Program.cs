using TestProject;
using System;
using TestProject.Enemies;
using TestProject.MainCharacter.CharacterServices;
using TestProject.MainCharacter.CharacterServices.Attacker.Attacks;
using TestProject.Models;
using TestProject.Shop;
using TestProject.StartUp.Engine;
using TestProject.TestCharacter.CharacterServices;

int show = 0;
int levelCounter = 1;
Inputer input = new Inputer();
RandomEnemyGenerator enemyGenerator = new RandomEnemyGenerator();
Enemy currentEnemy = enemyGenerator.GenerateRandomEnemy();
IAttack attackOne = new CharacterAttackOne();
IAttack attackTwo = new CharacterAttackTwo();
IAttack attackThree = new CharacterAttackThree();
PlayerStats playerStats = new PlayerStats();
Shop shop = new Shop();


Console.WriteLine("Welcome \nPress enter to start!");
Console.WriteLine("Select the name of your character!");
var name = "Pedal";
Character newCharacter = new Character(name);
Console.WriteLine($"Welcome {newCharacter.Name}!");
Console.WriteLine("You can use 1,2,3 for your abilties!");
Console.WriteLine("");
while (true)
{
    if (show == 0)
    {
        Console.WriteLine($"Welcome to level {levelCounter}!");
        Console.WriteLine($"You are facing {currentEnemy.Name}!");
        show++;
    }
    var move = input.PlayerInput()
        .ToLower();
    switch (move)
    {
        case "1":
           newCharacter.Attack = attackOne;
           newCharacter.GoAttack(newCharacter, currentEnemy);
            break;
        case "2":
            newCharacter.Attack = attackTwo;
            newCharacter.GoAttack(newCharacter, currentEnemy);
            break;
        case "3":
            newCharacter.Attack = attackThree;
            newCharacter.GoAttack(newCharacter, currentEnemy);
            break;
        case "shop":
            shop.DisplayItems();
            string[] tokens = Console.ReadLine()
                .Split();
            if (tokens[0] == "Buy")
            {
                if (tokens.Length >= 3)
                {
                    shop.BuyItem(newCharacter, tokens[1], int.Parse(tokens[2]));
                }
                else if (tokens.Length < 3)
                {
                    shop.BuyItem(newCharacter, tokens[1], 1);

                }
            }
            else if (tokens[0] == "back")
            {
                Console.WriteLine("Thanks for visiting the shop!");
                continue;
            }
            else
            {
                Console.WriteLine("Invalid input. Please use the format: Buy [item] [quantity]");
                continue;
            }
            break;
        case "inventory":
            newCharacter.Items.DisplayItems(newCharacter);
            var inventoryMove = input.PlayerInput()
                .ToLower()
                .Split()
                .ToArray();
            if (inventoryMove.Length >= 2 && inventoryMove[0] == "use")
            {
                string itemName = inventoryMove[1];
                if (itemName == "HealthPot")
                {
                    newCharacter.UseItem.UseItem(itemName, newCharacter);
                }
            }

            break;
        case "/kys":
            newCharacter.KillYourSelf();
            break;
        case "/kill":
            currentEnemy.Kill(currentEnemy);
            break;
        case "emote":
            newCharacter.Emote();
            break;
        default:
            Console.WriteLine("Invalid move. Please use 1, 2, 3 for your abilities.");
            continue;

    }

    if (currentEnemy.Health <= 0)
    {
        currentEnemy.EnemyGoldCalculator.CalculateGold(newCharacter,currentEnemy);
        currentEnemy.Die(currentEnemy);
        Console.WriteLine($"Total gold: {newCharacter.Gold}");
        levelCounter++;
        currentEnemy = enemyGenerator.GenerateRandomEnemy();
        playerStats.MonstersKilled += 1;
        show--;
        currentEnemy.LevelUp(currentEnemy);
    }

    if (newCharacter.IsCharacterDeath(newCharacter))
    {
        Console.WriteLine($"gg ur trash \n" +
                          $"Monsters killed: {playerStats.MonstersKilled}! \n" +
                          $"Gold colected: {playerStats.GoldColected}!\n" +
                          $"Level reached: {playerStats.Level}!");
        break;
    }
}

