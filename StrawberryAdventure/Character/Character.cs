using System;

namespace StrawberryAdventure
{
    public class Character : BasicCharacter, IHuman
    {
        private int _experience;

        public int Experience
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ExperienceForNextLevel
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}