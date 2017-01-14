using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrawberryAdventure.Units.NPC
{
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
