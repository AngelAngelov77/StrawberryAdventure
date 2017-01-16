<<<<<<< HEAD
﻿using System.Collections.Generic;

namespace StrawberryAdventure.Contracts
{
    public interface INPC : ICharacter
    {
        BasicItem DropItem();
=======
﻿
namespace StrawberryAdventure
{
    using System.Collections.Generic;

    public interface INPC
    {
        BasicItem DroppingItems { get; }
        BasicItem ItemsDropped();
>>>>>>> origin/shortVersion
    }
}
