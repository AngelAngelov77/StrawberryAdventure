using System;
using System.Collections.Generic;

namespace StrawberryAdventure
{
    public static class GameInterface
    {
        public static void Action(GameAction action, params object[] args)
        {
            switch (action)
            {
                case GameAction.Moving:
                    {
                        BasicCharacter hero = (BasicCharacter)args[0];
                        int x = (int)args[1];
                        int y = (int)args[2];
                        Console.WriteLine($"Hero {hero.Name} moved to position ({x}, {y}).");
                        break;
                    }
                case GameAction.ObstrackleHit:
                    {
                        BasicCharacter hero = (BasicCharacter)args[0];
                        int x = (int)args[1];
                        int y = (int)args[2];
                        int xOld = (int)args[3];
                        int yOld = (int)args[4];
                        Console.WriteLine($"Hero {hero.Name} found obstrackle at position ({x}, {y}) and stayed to position ({xOld}, {yOld}).");
                        break;
                    }
                case GameAction.ChestFound:
                    {
                        BasicCharacter hero = (BasicCharacter)args[0];
                        int x = (int)args[1];
                        int y = (int)args[2];
                        Chest chest = (Chest)args[3];
                        Console.WriteLine($"Hero {hero.Name} found chest at position ({x}, {y}).");
                        break;
                    }
                case GameAction.BattleStarted:
                    {
                        BasicCharacter hero = (BasicCharacter)args[0];
                        BasicCharacter npc = (BasicCharacter)args[1];
                        Console.WriteLine($"Hero {hero.Name} started battle with {npc.Name}.");
                        break;
                    }
                case GameAction.BattleHit:
                    {
                        BasicCharacter attacker = (BasicCharacter)args[0];
                        BasicCharacter defender = (BasicCharacter)args[1];
                        int defenderHP = (int)args[2];
                        int damage = (int)args[3];
                        Console.Write($"{attacker.Name} dealed {damage} damage to {defender.Name}. ");
                        defenderHP -= damage;
                        if (defenderHP > 0)
                        {
                            Console.WriteLine($"{defender.Name} hit points are {defenderHP}.");
                        }
                        break;
                    }
                case GameAction.BattleWon:
                    {
                        BasicCharacter hero = (BasicCharacter)args[0];
                        BasicCharacter npc = (BasicCharacter)args[1];
                        Console.WriteLine($"{hero.Name} defeats {npc.Name}");
                        break;
                    }
                case GameAction.BattleLost:
                    {
                        BasicCharacter hero = (BasicCharacter)args[0];
                        Console.WriteLine($"{hero.Name} has been defeated.");
                        break;
                    }
                case GameAction.ItemsGathered:
                    {
                        BasicCharacter hero = (BasicCharacter)args[0];
                        List<BasicItem> items = (List<BasicItem>)args[1];
                        string itemGathered = string.Join("\n", items);
                        Console.WriteLine($"Hero {hero.Name} gathered {itemGathered}.");
                        break;
                    }
                case GameAction.ExperienceGained:
                    {
                        Character hero = (Character)args[0];
                        int experience = (int)args[1];
                        Console.WriteLine($"Hero {hero.Name} gathered {experience} experience point. Total hero's experience is {hero.Experience + experience}.");
                        break;
                    }
                default:
                    Console.WriteLine("Unmanaged action!");
                    throw new ArgumentOutOfRangeException("Unmanaged action!");
            }
        }
    }
}
