using System;
using System.Collections.Generic;

namespace StrawberryAdventure
{
    public sealed class TheGame
    {
        private static volatile TheGame instance;
        private static object syncRoot = new Object();
        private static LevelingModel _levelingModel = new LevelingModel();
        List<Map> _maps;

        private TheGame()
        {
            //ToDo : generate maps, create hero
        }

        //Singelton
        public static TheGame GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new TheGame();
                    }
                }

                return instance;
            }
        }

        public List<Map> Maps
        {
            get
            {
                return _maps;
            }
        }

        public Character Hero
        {
            get
            {
                throw new System.NotImplementedException();
            }

        }

        public void AddMap(Map map)
        {
            Maps.Add(map);
        }



        private bool Battle(Character hero, NPC npc)
        {
            GameInterface.Action(GameAction.BattleStarted, hero, npc);
            int heroHP = hero.HitPoints;
            int npcHP = npc.HitPoints;
            while (true)
            {
                int damage = DamageCalculator(hero, npc); //hero deals damage to npc
                GameInterface.Action(GameAction.BattleHit, npc, hero, heroHP, damage);
                npcHP -= damage;
                if (npcHP <= 0)
                {
                    GameInterface.Action(GameAction.BattleWon, hero, npc);
                    return true;
                }
                damage = DamageCalculator(npc, hero); //npc deals damage to hero
                GameInterface.Action(GameAction.BattleHit, npc, hero, heroHP, damage);
                heroHP -= damage;
                if (heroHP <= 0)
                {
                    GameInterface.Action(GameAction.BattleLost, hero);
                    return false;
                }
            }
        }

        private static int DamageCalculator(BasicCharacter attacker, BasicCharacter defender)
        {
            int damage = 0;
            int damageIndex = attacker.Attack - defender.Defense;
            damage = Rnd.Random(7 * damageIndex);
            return damage;
        }

        public void HandleInput(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    //To Do - try move left
                    break;
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    //To Do - try move up
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    //To Do - try move right
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    //To Do - try move down
                    break;
                case ConsoleKey.I:
                    //ToDo - show inventory inteface
                    break;
                case ConsoleKey.H:
                    //ToDo - show hero skills interface
                    break;
                case ConsoleKey.M:
                    //ToDo - show map
                    break;
                default:
                    break;
            }
            Console.WriteLine(key.KeyChar);
        }
    }
}