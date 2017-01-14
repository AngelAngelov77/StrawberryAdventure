
namespace StrawberryAdventure
{
    using System.Collections.Generic;

    public interface INPC
    {
        BasicItem DroppingItems { get; }
        BasicItem ItemsDropped();
    }
}
