using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrawberryAdventure
{
    class Startup
    {
        static void Main()
        {
            TheGame StrawberryAdventute = TheGame.GetInstance;

            List<ItemsDrop> mravkaDrop = new List<ItemsDrop>();
            mravkaDrop.Add(new ItemsDrop(new Weapon("Mitika", 1, 0), 80));
            mravkaDrop.Add(new ItemsDrop(new BodyArmor("Riznica", 10, 80, -3, -4, 5), 40));
            mravkaDrop.Add(new ItemsDrop(new Necklace("Ogyrlica", 10, 2, 2, 5), 5));
            Inventory mravkataInventory = new Inventory();
            mravkataInventory.EquipItem(new LeggingsArmor("Pantaloni", 2, 5, 0, 0));
            NPC mravka = new NPC("Fredi Mravkata", 10, 1, 1, 1, 1, mravkataInventory, 100000, mravkaDrop, 10);

            List<BasicItem> chestItems = new List<BasicItem>();
            chestItems.Add(new Weapon("Yatagan", 10, 2));
            chestItems.Add(new Helmet("Kaska", 4, 10));
            chestItems.Add(new Ring("Brachna halka", 15, 1, 1, 100));

            Chest chest = new Chest(5, true, chestItems);

            MapObject[,] layout = new MapObject[20, 20];
            for (int i = 0; i < 20; i++) //Огражда картата с препядствия
            {
                layout[0, i] = new MapObject { Type = MapObjectType.Obstracle, Object = null };
                layout[19, i] = new MapObject { Type = MapObjectType.Obstracle, Object = null };
                layout[i, 0] = new MapObject { Type = MapObjectType.Obstracle, Object = null };
                layout[i,19] = new MapObject { Type = MapObjectType.Obstracle, Object = null };
            }

            layout[7, 9] = new MapObject { Type = MapObjectType.Chest, Object = chest };


            Map testMap = new Map(20, 20);
            testMap.SetLayout(layout);
            Map testMap2 = new Map(layout);

            Skill weaponMastery = new Skill("Weapon Mastery", 0,
                                            attackBonusBasic: 3,
                                            attackBonusPerLevel: 1);
            Skill armorMastery = new Skill("Armor Mastery", 1,
                                            defenseBonusBasic: 3,
                                            defenseBonusPerLevel: 1);
            Skill ironBody = new Skill("Iron Body", 0,
                                        hitPointsBonusBasic: 10,
                                        hitPointsBonusPerLevel: 5);
            Skill battleProficiency = new Skill("Battle Proficiency",
                                                accuracyBonusBasic: 2,
                                                accuracyBonusPerLevel: 1);
            Skill agility = new Skill("Agility", 0,
                                      evasionBonusBasic: 2,
                                      evasionBonusPerLevel: 1);
            Skill theftMastery = new Skill("Theft Mastery",
                                            chestUnlockLevelBasic: 1,
                                            chestUnlockLevelPerLevel: 1);
            Skill cleverness = new Skill("Cleverness", 0,
                                         experienceModifierBasic: 10,
                                         experienceModifierPerLevel: 2);
            List<BasicSkill> skills = new List<BasicSkill>();
            skills.Add(weaponMastery);
            skills.Add(ironBody);
            Character hero = new Character("Yagodko", 60, 5, 5, 3, 3, skills: skills);

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                //ToDo - handle arrows, w, a, s, d - moving the hero, h - show hero menu, m - show map (optional)
                StrawberryAdventute.HandleInput(keyinfo.KeyChar);
            }
            while (keyinfo.Key != ConsoleKey.Escape);
        }
    }
}
