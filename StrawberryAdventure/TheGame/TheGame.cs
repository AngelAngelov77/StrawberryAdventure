using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            Console.WriteLine($"Hero {hero.Name} started battle with {npc.Name}.");
            int heroHP = hero.HitPoints;
            int npcHP = npc.HitPoints;
            while (true)
            {
                int damage = DamageCalculator(hero, npc); //hero deals damage to npc
                Console.Write($"{hero.Name} dealed {damage} damage to {npc.Name}. ");
                npcHP -= damage;
                if (npcHP > 0)
                {
                    Console.WriteLine($"{npc.Name} hit points are {npcHP}.");
                }
                else
                {
                    Console.WriteLine($"{hero.Name} defeats {npc.Name}");
                    return true;
                }
                damage = DamageCalculator(npc, hero); //npc deals damage to hero
                Console.Write($"{npc.Name} dealed {damage} damage to {hero.Name}. ");
                heroHP -= damage;
                if (heroHP > 0)
                {
                    Console.WriteLine($"{hero.Name} hit points are {npcHP}.");
                }
                else
                {
                    Console.WriteLine($"{hero.Name} has been defeated.");
                    return false;
                }
            }
        }

        private static int DamageCalculator(BasicCharacter attacker, BasicCharacter defender)
        {
            int damage = 0;
            if (Rnd.Random(attacker.Accuracy) > Rnd.Random(defender.Evasion)) //Check successful hit
            {
                int damageIndex = attacker.Attack - defender.Defense;
                damage = Rnd.Random(7 * damageIndex);
                bool critical = Rnd.Random(100) < 15;
                if (critical)
                {
                    damage = 2 * damage;
                }
            }

            return damage;
        }

        public void HandleInput(char key)
        {
            Console.WriteLine(key);
        }
    }
}