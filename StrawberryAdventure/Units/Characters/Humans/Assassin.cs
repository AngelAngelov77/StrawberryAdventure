using System;
using System.Collections.Generic;
using StrawberryAdventure.Characters;
using StrawberryAdventure.Contracts;

namespace StrawberryAdventure.Units.Characters.Humans
{
    public class Assassin : Character,ICharacter,IHuman
    {
        public Assassin(string name) : base(name,80,30,40)
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
