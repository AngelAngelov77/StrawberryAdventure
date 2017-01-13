namespace StrawberryAdventure
{
    using System.Collections.Generic;

    public class NPC : BasicCharacter, INPC, IIdentifiable
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

        public BasicItem ItemsDropped()
        {
             return itemsDropList;
        }
    }
}
