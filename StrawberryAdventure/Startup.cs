﻿using System;
using System.Collections.Generic;
using StrawberryAdventure.Engine;
namespace StrawberryAdventure
{
    public class Startup
    {
        public static void Main()
        {
<<<<<<< HEAD
            Game StrawberryAdventure = Game.GetInstance;
=======
            //WElcome
            Console.WriteLine(WelcomeScreen.Welcome());
            
            WelcomeScreen.Song();

            /////////////////////////////////////////////////////////


            Game StrawberryAdventute = Game.GetInstance;
>>>>>>> origin/shortVersion

            List<ItemsDrop> mravkaDrop = new List<ItemsDrop>();
            mravkaDrop.Add(new ItemsDrop(new Weapon("Mitika", 1), 80));
            mravkaDrop.Add(new ItemsDrop(new Armor("Riznica", 10, 80), 40));
            mravkaDrop.Add(new ItemsDrop(new Necklace("Ogyrlica", 10), 5));
            List<BasicItem> chestItems = new List<BasicItem>();
            chestItems.Add(new Weapon("Yatagan", 10));
            chestItems.Add(new Helmet("Kaska", 4, 10));
            chestItems.Add(new Ring("Brachna halka", 15));

            Chest chest = new Chest(chestItems);

            MapObject[,] layout = new MapObject[20, 20];
            for (int i = 0; i < 20; i++) //Огражда картата с препядствия
            {
                layout[0, i] = new MapObject { Type = MapObjectType.Obstracle, Object = null };
                layout[19, i] = new MapObject { Type = MapObjectType.Obstracle, Object = null };
                layout[i, 0] = new MapObject { Type = MapObjectType.Obstracle, Object = null };
                layout[i, 19] = new MapObject { Type = MapObjectType.Obstracle, Object = null };
            }

            layout[7, 9] = new MapObject { Type = MapObjectType.Chest, Object = chest };

            Map testMap = new Map(20, 20);
            testMap.SetLayout(layout);
            Map testMap2 = new Map(layout);

            Character hero = new Character("Yagodko", 60, 5, 5);

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                //ToDo - handle arrows, w, a, s, d - moving the hero, h - show hero menu, m - show map (optional)
                StrawberryAdventure.HandleInput(keyinfo);
            }
            while (keyinfo.Key != ConsoleKey.Escape);
        }
    }
}
