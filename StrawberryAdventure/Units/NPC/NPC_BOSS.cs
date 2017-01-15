namespace StrawberryAdventure.Units.NPC
{
    using System;

    class NPC_BOSS : INPC
    {
        

        public NPC_BOSS(string name, int attack, int defense)
        {
                
        }
        BasicItem INPC.DroppingItems
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        BasicItem INPC.ItemsDropped()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            //TODO
            //attack plyer
        }
    }
}
