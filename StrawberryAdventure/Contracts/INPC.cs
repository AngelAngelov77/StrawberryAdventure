using System.Collections.Generic;

namespace StrawberryAdventure
{
    public interface INPC
    {
        BasicItem DroppingItems { get; }
        BasicItem ItemsDropped();
    }
}
