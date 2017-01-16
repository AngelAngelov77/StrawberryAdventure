using System;
using System.Collections.Generic;
using StrawberryAdventure.Characters;
using StrawberryAdventure.Contracts;

namespace StrawberryAdventure.Units.Characters.Humans
{
    public class Tank : Character,ICharacter,IHuman
    {
        public Tank(string name) : base(name, 20, 60, 70)
        {
        }

        public ICollection<IBasicItem> Items
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
