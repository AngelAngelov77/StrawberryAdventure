using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrawberryAdventure
{
    public interface ICharacterInventory
    {
        BasicItem ItemBody { get; set; }

        BasicItem ItemHead { get; set; }

        BasicItem ItemLeftHand { get; set; }

        BasicItem ItemLeftRing { get; set; }

        BasicItem ItemLegs { get; set; }

        BasicItem ItemRightHand { get; set; }
        BasicItem ItemRightRing { get; set; }
        BasicItem[] ItemsInBelt { get; set; }
        BasicItem ItemBelt { get; set; }
        List<BasicItem> ItemsInBackpack { get; set; }
        int ItemNeckle { get; set; }
    }
}