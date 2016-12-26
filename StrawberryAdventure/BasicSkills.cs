using System.Text;

namespace StrawberryAdventure
{
    public abstract class BasicSkills
    {
        private const int ValueAccuracy = 100;
        public virtual string Name { get; protected set; }
        public virtual string Description { get { return this.ToString(); } }
        public virtual int Level { get; private set; }

        public virtual int ExperienceModifier { get { return this.ExperienceModifierBasic + (this.Level * this.ExperienceModifierPerLevel) / ValueAccuracy; } }
        public virtual int AttackBonus { get { return this.AttackBonusBasic + (this.Level * this.AttackBonusPerLevel) / ValueAccuracy; } }
        public virtual int AttackModifier { get { return this.AttackBonusBasic + (this.Level * this.AttackBonusPerLevel) / ValueAccuracy; } }
        public virtual int DefenseBonus { get { return this.DefenseBonusBasic + (this.Level * this.DefenseBonusPerLevel) / ValueAccuracy; } }
        public virtual int DefenseModifier { get { return this.DefenseModifierBasic + (this.Level * this.DefenseModifierPerLevel) / ValueAccuracy; } }
        public virtual int AccuracyBonus { get { return this.AccuracyBonusBasic + (this.Level * this.AccuracyBonusPerLevel) / ValueAccuracy; } }
        public virtual int AccuracyModifier { get { return this.AccuracyModifierBasic + (this.Level * this.AccuracyModifierPerLevel) / ValueAccuracy; } }
        public virtual int CriticalRateBonus { get { return this.CriticalRateBonusBasic + (this.Level * this.CriticalRateBonusPerLevel) / ValueAccuracy; } }
        public virtual int CriticalRateModifier { get { return this.CriticalRateModifierBasic + (this.Level * this.CriticalRateModifierPerLevel) / ValueAccuracy; } }
        public virtual int CriticalDamageBonus { get { return this.CriticalDamageBonusBasic + (this.Level * this.CriticalDamageBonusPerLevel) / ValueAccuracy; } }
        public virtual int CriticalDamageModifier { get { return this.CriticalDamageModifierBasic + (this.Level * this.CriticalDamageModifierPerLevel) / ValueAccuracy; } }
        public virtual int HitPointsBonus { get { return this.HitPointsBonusBasic + (this.Level * this.HitPointsBonusPerLevel) / ValueAccuracy; } }
        public virtual int HitPointsModifier { get { return this.HitPointsModifierBasic + (this.Level * this.HitPointsModifierPerLevel) / ValueAccuracy; } }
        public virtual int EvasionBonus { get { return this.EvasionBonusBasic + (this.Level * this.EvasionBonusPerLevel) / ValueAccuracy; } }
        public virtual int EvasionModifier { get { return this.EvasionModifierBasic + (this.Level * this.EvasionModifierPerLevel) / ValueAccuracy; } }
        public virtual int ChestUnlockLevel { get { return this.ChestUnlockLevelBasic + (this.Level * this.ChestUnlockLevelPerLevel) / ValueAccuracy; } }

        public virtual int ExperienceModifierBasic { get; protected set; }
        public virtual int AttackBonusBasic { get; protected set; }
        public virtual int AttackModifierBasic { get; protected set; }
        public virtual int DefenseBonusBasic { get; protected set; }
        public virtual int DefenseModifierBasic { get; protected set; }
        public virtual int AccuracyBonusBasic { get; protected set; }
        public virtual int AccuracyModifierBasic { get; protected set; }
        public virtual int CriticalRateBonusBasic { get; protected set; }
        public virtual int CriticalRateModifierBasic { get; protected set; }
        public virtual int CriticalDamageBonusBasic { get; protected set; }
        public virtual int CriticalDamageModifierBasic { get; protected set; }
        public virtual int HitPointsBonusBasic { get; protected set; }
        public virtual int HitPointsModifierBasic { get; protected set; }
        public virtual int EvasionBonusBasic { get; protected set; }
        public virtual int EvasionModifierBasic { get; protected set; }
        public virtual int ChestUnlockLevelBasic { get; protected set; }

        public virtual int ExperienceModifierPerLevel { get; protected set; }
        public virtual int AttackBonusPerLevel { get; protected set; }
        public virtual int AttackModifierPerLevel { get; protected set; }
        public virtual int DefenseBonusPerLevel { get; protected set; }
        public virtual int DefenseModifierPerLevel { get; protected set; }
        public virtual int AccuracyBonusPerLevel { get; protected set; }
        public virtual int AccuracyModifierPerLevel { get; protected set; }
        public virtual int CriticalRateBonusPerLevel { get; protected set; }
        public virtual int CriticalRateModifierPerLevel { get; protected set; }
        public virtual int CriticalDamageBonusPerLevel { get; protected set; }
        public virtual int CriticalDamageModifierPerLevel { get; protected set; }
        public virtual int HitPointsBonusPerLevel { get; protected set; }
        public virtual int HitPointsModifierPerLevel { get; protected set; }
        public virtual int EvasionBonusPerLevel { get; protected set; }
        public virtual int EvasionModifierPerLevel { get; protected set; }
        public virtual int ChestUnlockLevelPerLevel { get; protected set; }

        protected BasicSkills()
        {
            Level = 1;
        }

        protected void LevelUp()
        {
            this.Level++;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{this.Name} enchances character");

            //To Do Append to result bonuses if > 0
            return result.ToString();
        }
    }
}