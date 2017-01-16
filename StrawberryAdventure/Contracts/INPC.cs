using System.Collections.Generic;

namespace StrawberryAdventure.Contracts
{
    public interface INPC : ICharacter
    {
        BasicItem DropItem();
    }
}
