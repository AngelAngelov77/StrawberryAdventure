using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrawberryAdventure
{
    public interface INPC
    {
        int Experience { get; set; }
        ItemsDrop[] DroppingItems { get; set; }
        BodyPositions BodyPositions { get; set; }
    }
}