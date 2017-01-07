using System;
using System.Collections.Generic;

namespace StrawberryAdventure
{
    public class Character : BasicCharacter, IHuman
    {
        private int _experience;

        public Character(string name, int hitPoints, int basicAttack, int basicDefense, int basicAccuracy, int basicEvasion,
                              int basicCriticalRate, int skillPoints = 0, List<BasicSkill> skills = null)
        {
            Name = name;
            BasicHitPoints = hitPoints;
            BasicAttack = basicAttack;
            BasicDefense = basicDefense;
            BasicAccuracy = basicAccuracy;
            BasicEvasion = basicEvasion;
            BasicCriticalRate = basicCriticalRate;
            SkillPoints = skillPoints;
            InitSkills(skills);
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

        private void InitSkills(List<BasicSkill> skills)
        {

        }
    }
}