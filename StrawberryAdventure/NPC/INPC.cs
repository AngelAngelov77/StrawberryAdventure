using System.Collections.Generic;

namespace StrawberryAdventure
{
    public interface INPC
    {
        List<ItemsDrop> DroppingItems { get; }

        List<BasicItem> ItemsDropped();
    }
}
