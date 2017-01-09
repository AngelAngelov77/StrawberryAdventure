using System.Collections.Generic;

namespace StrawberryAdventure
{
    public interface INPC
    {
        IList<ItemsDrop> DroppingItems { get; }

        IList<BasicItem> ItemsDropped();
    }
}
