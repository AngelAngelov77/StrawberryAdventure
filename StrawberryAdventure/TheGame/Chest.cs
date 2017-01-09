using System;
using System.Collections.Generic;

namespace StrawberryAdventure
{
    public class Chest
    {
        private List<BasicItem> _items;

        public Chest(List<BasicItem> items)
        {
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
        
        public List<BasicItem> Items
        {
            get
            {
                return _items;
            }
        }
    }
}