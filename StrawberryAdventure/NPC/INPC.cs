using System.Collections.Generic;

namespace StrawberryAdventure
{
    public interface INPC
    {
        int Experience { get; }
        List<ItemsDrop> DroppingItems { get; }

        List<BasicItem> ItemsDropped();
    }
}