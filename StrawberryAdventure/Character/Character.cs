using System.Collections.Generic;

namespace StrawberryAdventure
{
    public class Character : BasicCharacter, IHuman
    {
        private int _experience;

        public Character(string name, int hitPoints, int basicAttack, int basicDefense)
        {
            Name = name;
            BasicHitPoints = hitPoints;
            BasicAttack = basicAttack;
            BasicDefense = basicDefense;
        }

        public Character(Character character) : this(character.Name, character.HitPoints, character.BasicAttack, character.BasicDefense)
        {
        }

        public int Experience
        {
            get
            {
                return _experience;
            }
        }

        public int ExperienceForNextLevel
        {
            get
            {
                return 0;
            }
        }

        public bool AddExperience(int experienceGained, LevelingModel levelingModel)
        {
            bool result;
            _experience = levelingModel.AddExperience(Experience, experienceGained, out result);
            return result;
        }
    }
}
