using System;

namespace StrawberryAdventure
{
    public class Skill : BasicSkill
    {
        public Skill(string name,
                     int level = 1,
                     int experienceModifierBasic = 0, int experienceModifierPerLevel = 0,
                     int attackBonusBasic = 0, int attackBonusPerLevel = 0,
                     int defenseBonusBasic = 0, int defenseBonusPerLevel = 0,
                     int accuracyBonusBasic = 0, int accuracyBonusPerLevel = 0,
                     int hitPointsBonusBasic = 0, int hitPointsBonusPerLevel = 0,
                     int evasionBonusBasic = 0, int evasionBonusPerLevel = 0,
                     int chestUnlockLevelBasic = 0, int chestUnlockLevelPerLevel = 0) 
                            : base(name, level,
                                   experienceModifierBasic,         experienceModifierPerLevel,
                                   attackBonusBasic,                attackBonusPerLevel,
                                   defenseBonusBasic,               defenseBonusPerLevel,
                                   accuracyBonusBasic,              accuracyBonusPerLevel,
                                   hitPointsBonusBasic,             hitPointsBonusPerLevel,
                                   evasionBonusBasic,               evasionBonusPerLevel,
                                   chestUnlockLevelBasic,           chestUnlockLevelPerLevel)
        {
            
        }
    }
}
