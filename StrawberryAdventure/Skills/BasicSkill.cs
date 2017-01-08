using System.Text;

namespace StrawberryAdventure
{
    public abstract class BasicSkill : ISkill, IIdentifiable
    {
        private int _id;
        public string Name { get; private set; }
        public string Description { get { return ToString(); } }
        public int Level { get; private set; }

        public int ExperienceModifier { get { return Level > 0 ? ExperienceModifierBasic + (Level * ExperienceModifierPerLevel) : 0; } }
        public int AttackBonus { get { return Level > 0 ? AttackBonusBasic + (Level * AttackBonusPerLevel) : 0; } }
        public int DefenseBonus { get { return Level > 0 ? DefenseBonusBasic + (Level * DefenseBonusPerLevel) : 0; } }
        public int AccuracyBonus { get { return Level > 0 ? AccuracyBonusBasic + (Level * AccuracyBonusPerLevel) : 0; } }
        public int CriticalRateBonus { get { return Level > 0 ? + (Level * CriticalRateBonusPerLevel) : 0; } }
        public int HitPointsBonus { get { return Level > 0 ? HitPointsBonusBasic + (Level * HitPointsBonusPerLevel) : 0; } }
        public int EvasionBonus { get { return Level > 0 ? EvasionBonusBasic + (Level * EvasionBonusPerLevel) : 0; } }
        public int ChestUnlockLevel { get { return Level > 0 ? ChestUnlockLevelBasic + (Level * ChestUnlockLevelPerLevel) : 0; } }

        public int ExperienceModifierBasic { get; private set; }
        public int AttackBonusBasic { get; private set; }
        public int DefenseBonusBasic { get; private set; }
        public int AccuracyBonusBasic { get; private set; }
        public int CriticalRateBonusBasic { get; private set; }
        public int HitPointsBonusBasic { get; private set; }
        public int EvasionBonusBasic { get; private set; }
        public int ChestUnlockLevelBasic { get; private set; }

        public int ExperienceModifierPerLevel { get; private set; }
        public int AttackBonusPerLevel { get; private set; }
        public int DefenseBonusPerLevel { get; private set; }
        public int AccuracyBonusPerLevel { get; private set; }
        public int CriticalRateBonusPerLevel { get; private set; }
        public int HitPointsBonusPerLevel { get; private set; }
        public int EvasionBonusPerLevel { get; private set; }

        public int ChestUnlockLevelPerLevel { get; private set; }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        protected BasicSkill(string name,
                            int level = 1,
                            int experienceModifierBasic = 0,        int experienceModifierPerLevel = 0,
                            int attackBonusBasic = 0,               int attackBonusPerLevel = 0,
                            int defenseBonusBasic = 0,              int defenseBonusPerLevel = 0,
                            int accuracyBonusBasic = 0,             int accuracyBonusPerLevel = 0,
                            int criticalRateBonusBasic = 0,         int criticalRateBonusPerLevel = 0,
                            int hitPointsBonusBasic = 0,            int hitPointsBonusPerLevel = 0,
                            int evasionBonusBasic = 0,              int evasionBonusPerLevel = 0,
                            int chestUnlockLevelBasic = 0,          int chestUnlockLevelPerLevel = 0)
        {
            Name = name;
            Level = level;

            ExperienceModifierBasic = experienceModifierBasic;
            AttackBonusBasic = attackBonusBasic;
            DefenseBonusBasic = defenseBonusBasic;
            AccuracyBonusBasic = accuracyBonusBasic;
            CriticalRateBonusBasic = criticalRateBonusBasic;
            HitPointsBonusBasic = hitPointsBonusBasic;
            EvasionBonusBasic = evasionBonusBasic;
            ChestUnlockLevelBasic = chestUnlockLevelBasic;

            ExperienceModifierPerLevel = experienceModifierPerLevel;
            AttackBonusPerLevel = attackBonusPerLevel;
            DefenseBonusPerLevel = defenseBonusPerLevel;
            AccuracyBonusPerLevel = accuracyBonusPerLevel;
            CriticalRateBonusPerLevel = criticalRateBonusPerLevel;
            HitPointsBonusPerLevel = hitPointsBonusPerLevel;
            EvasionBonusPerLevel = evasionBonusPerLevel;
            ChestUnlockLevelPerLevel = chestUnlockLevelPerLevel;

            _id = Identifiable.GetID();

        }

        public void LevelUp()
        {
            Level++;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{Name} enchances character");
            if (AttackBonus > 0)
            {
                result.AppendLine($"  Attack by {AttackBonus}");
            }
            if (DefenseBonus > 0)
            {
                result.AppendLine($"  Defense by: {DefenseBonus}");
            }
            if (HitPointsBonus > 0)
            {
                result.AppendLine($"  Hit points: {HitPointsBonus}");
            }
            if (AccuracyBonus > 0)
            {
                result.AppendLine($"  Accuracy: {AccuracyBonus}");
            }
            if (EvasionBonus > 0)
            {
                result.AppendLine($"  Evasion: {EvasionBonus}");
            }
            if (ExperienceModifier > 0)
            {
                result.AppendLine($"  Experience bonus {ExperienceModifier} %");
            }
            if (ChestUnlockLevel > 0)
            {
                result.AppendLine($"Unlock chest with 100% probability up to level {ChestUnlockLevel}");
                result.AppendLine(@"There is a chanse to unlock upper level chests,
but the probability greately decreases 
with the level difference.");
            }

            return result.ToString();
        }
    }
}
