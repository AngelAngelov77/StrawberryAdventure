using System.Collections.Generic;

namespace StrawberryAdventure
{
    public class Character : BasicCharacter, IHuman
    {
        private int _experience;

        public Character(string name, int hitPoints, int basicAttack, int basicDefense, int basicAccuracy, int basicEvasion,
                         int skillPoints = 0, List<BasicSkill> skills = null)
        {
            Name = name;
            BasicHitPoints = hitPoints;
            BasicAttack = basicAttack;
            BasicDefense = basicDefense;
            BasicAccuracy = basicAccuracy;
            BasicEvasion = basicEvasion;
            SkillPoints = skillPoints;
            Skills = skills;
        }

        public Character(Character character) : this(character.Name, character.HitPoints, character.BasicAttack, character.BasicDefense, 
                                                     character.BasicAccuracy, character.BasicEvasion,
                                                     character.SkillPoints, character.Skills)
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
