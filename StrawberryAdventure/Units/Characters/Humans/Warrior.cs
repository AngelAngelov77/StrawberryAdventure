using System;
using System.Collections.Generic;
using StrawberryAdventure.Characters;
using StrawberryAdventure.Contracts;

namespace StrawberryAdventure.Units.Characters.Humans
{
    public class Warrior : Character,ICharacter,IHuman
    {
        public Warrior(string name) : base(name, 60, 40, 50)
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
