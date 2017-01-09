using System;
using System.Collections.Generic;

namespace StrawberryAdventure
{
    public class Chest
    {
        private IList<BasicItem> items;

        public Chest(List<BasicItem> itemsList)
        {
            if (items != null)
            {
                items = itemsList;
            }
            else
            {
                items = new List<BasicItem>();
            }
        }
        
        public void AddItem(BasicItem item)
        {
            items.Add(item);
        }
        
        public IList<BasicItem> Items
        {
            get
            {
                return items;
            }
        }
    }
}