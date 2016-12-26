using System;

namespace StrawberryAdventure
{
    public class Skill : BasicSkills
    {
        public Skill(string name,
                     int level = 1,
                     int experienceModifierBasic = 0,
                     int experienceModifierPerLevel = 0,
                     int attackBonusBasic = 0,
                     int attackBonusPerLevel = 0,
                     int attackModifierBasic = 0,
                     int attackModifierPerLevel = 0,
                     int defenseBonusBasic = 0,
                     int defenseBonusPerLevel = 0,
                     int defenseModifierBasic = 0,
                     int defenseModifierPerLevel = 0,
                     int accuracyBonusBasic = 0,
                     int accuracyBonusPerLevel = 0,
                     int accuracyModifierBasic = 0,
                     int accuracyModifierPerLevel = 0,
                     int criticalRateBonusBasic = 0,
                     int criticalRateBonusPerLevel = 0,
                     int criticalRateModifierBasic = 0,
                     int criticalRateModifierPerLevel = 0,
                     int criticalDamageBonusBasic = 0,
                     int criticalDamageBonusPerLevel = 0,
                     int criticalDamageModifierBasic = 0,
                     int criticalDamageModifierPerLevel = 0,
                     int hitPointsBonusBasic = 0,
                     int hitPointsBonusPerLevel = 0,
                     int hitPointsModifierBasic = 0,
                     int hitPointsModifierPerLevel = 0,
                     int evasionBonusBasic = 0,
                     int evasionBonusPerLevel = 0,
                     int evasionModifierBasic = 0,
                     int evasionModifierPerLevel = 0,
                     int chestUnlockLevelBasic = 0,
                     int chestUnlockLevelPerLevel = 0)
        {
            this.Name = name;
            this.ExperienceModifierBasic = experienceModifierBasic;
            this.ExperienceModifierPerLevel = experienceModifierPerLevel;
            this.AttackBonusBasic = attackBonusBasic;
            this.AttackBonusPerLevel = attackBonusPerLevel;
            this.AttackModifierBasic = attackModifierBasic;
            this.AttackModifierPerLevel = attackModifierPerLevel;
            this.DefenseBonusBasic = defenseBonusBasic;
            this.DefenseBonusPerLevel = defenseBonusPerLevel;
            this.DefenseModifierBasic = defenseModifierBasic;
            this.DefenseModifierPerLevel = defenseModifierPerLevel;
            this.AccuracyBonusBasic = accuracyBonusBasic;
            this.AccuracyBonusPerLevel = accuracyBonusPerLevel;
            this.AccuracyModifierBasic = accuracyModifierBasic;
            this.AccuracyModifierPerLevel = accuracyModifierPerLevel;
            this.CriticalRateBonusBasic = criticalRateBonusBasic;
            this.CriticalRateBonusPerLevel = criticalRateBonusPerLevel;
            this.CriticalRateModifierBasic = criticalRateModifierBasic;
            this.CriticalRateModifierPerLevel = criticalRateModifierPerLevel;
            this.CriticalDamageBonusBasic = criticalDamageBonusBasic;
            this.CriticalDamageBonusPerLevel = criticalDamageBonusPerLevel;
            this.CriticalDamageModifierBasic = criticalDamageModifierBasic;
            this.CriticalDamageModifierPerLevel = criticalDamageModifierPerLevel;
            this.HitPointsBonusBasic = hitPointsBonusBasic;
            this.HitPointsBonusPerLevel = hitPointsBonusPerLevel;
            this.HitPointsModifierBasic = hitPointsModifierBasic;
            this.HitPointsModifierPerLevel = hitPointsModifierPerLevel;
            this.EvasionBonusBasic = evasionBonusBasic;
            this.EvasionBonusPerLevel = evasionBonusPerLevel;
            this.EvasionModifierBasic = evasionModifierBasic;
            this.EvasionModifierPerLevel = evasionModifierPerLevel;
            this.ChestUnlockLevelBasic = chestUnlockLevelBasic;
            this.ChestUnlockLevelPerLevel = chestUnlockLevelPerLevel;
            for (int i = 1; i < level; i++)
            {
                this.LevelUp();
            }
        }
    }
}