using System;
using System.Collections.Generic;

namespace StrawberryAdventure
{
    public class Chest : IIdentifiable
    {
        private int _id;
        private int _level;
        private ItemQuality _quality;
        List<BasicItem> _items;

        public Chest(int level, ItemQuality quality, List<BasicItem> items)
        {
            _id = Idetifiable.GetID();
            _level = level;
            _quality = quality;
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

        public ItemQuality Quality
        {
            get
            {
                return _quality;
            }
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
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }
    }
}