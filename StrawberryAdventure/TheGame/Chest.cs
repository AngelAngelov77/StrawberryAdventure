using System;
using System.Collections.Generic;

namespace StrawberryAdventure
{
    public class Chest : IIdentifiable
    {
        private int _id;
        private int _level;
        private bool _locked;
        private List<BasicItem> _items;

        public Chest(int level, bool locked, List<BasicItem> items)
        {
            _id = Identifiable.GetID();
            _level = level;
            _locked = locked;
            if (items != null)
            {
                _items = items;
            }
            else
            {
                _items = new List<BasicItem>();
            }
        }
        
        public void AddItem(BasicItem item)
        {
            _items.Add(item);
        }
        
        public int Level
        {
            get
            {
                return _level;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException($"Chest level {value} should be 1 or greater.");
                }
                _level = value;
            }
        }

        public List<BasicItem> Items
        {
            get
            {
                return _items;
            }
        }

        public bool Locked
        {
            get
            {
                return _locked;
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public bool Unlock(Character character)
        {
            if (character.ChestUnlockSkill < Level)
            {
                return (Rnd.Random(100) < ChestUnlockChance(Level - character.ChestUnlockSkill));
            }
            else
            {
                return true;
            }
        }

        private int ChestUnlockChance(int levelDifference)
        {
            return 50 / (levelDifference * levelDifference);
        }
    }
}
