namespace StrawberryAdventure
{
    using System;
    using System.Collections.Generic;

    public class NPC : BasicCharacter, INPC, IIdentifiable
    {
        private int healthPoints;


        //private int _id;
        private BasicItem itemsDropList;

        public NPC(string name, int hitPoint, int attack, int defense /*, BasicItem itemsDrop*/) : base(name,hitPoint,attack,defense)
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

        public void DropItem()
        {
            //TODO finish
            Random rand = new Random(DateTime.Now.Millisecond);
        }

        public void killNPC(NPC npc)
        {
            if (npc.healthPoints == 0)
            {
                //drop item
                // delete npc
            }
        }
              
    }
}
