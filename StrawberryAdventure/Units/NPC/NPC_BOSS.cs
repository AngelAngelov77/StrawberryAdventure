namespace StrawberryAdventure.Units.NPC
{
    using System;

    class NPC_BOSS : INPC
    {
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
