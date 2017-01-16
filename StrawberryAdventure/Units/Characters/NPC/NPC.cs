namespace StrawberryAdventure.Units.Characters.NPC
{
    using Contracts;
    using StrawberryAdventure.Characters;
    using System.Collections.Generic;
    using System;

    public class NPC : Character, INPC
    {
        //private int _id;
        private BasicItem itemsDropList;

        public NPC(string name, int hitPoint, int attack, int defense, BasicItem itemsDrop) : base(name,hitPoint,attack,defense)
        {            
        }

        public BasicItem DroppingItems
        {
            get
            {
                return itemsDropList;
            }
        }

        public BasicItem DropItem()
        {
            throw new NotImplementedException();
        }

        public BasicItem ItemsDropped()
        {
             return itemsDropList;
        }
    }
}
