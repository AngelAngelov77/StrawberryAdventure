namespace StrawberryAdventure.Units.Characters.NPC
{
<<<<<<< HEAD:StrawberryAdventure/Units/Characters/NPC/NPC.cs
    using Contracts;
    using StrawberryAdventure.Characters;
=======
    using System;
>>>>>>> origin/shortVersion:StrawberryAdventure/Units/NPC/NPC.cs
    using System.Collections.Generic;
    using System;

    public class NPC : Character, INPC
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

        public BasicItem DropItem()
        {
            throw new NotImplementedException();
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
