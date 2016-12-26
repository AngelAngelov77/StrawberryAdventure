using System.Text;

namespace StrawberryAdventure
{
    public abstract class BasicItem
    {
        public BodyPositions BodyPosition { get; private set; }
        public int BonusAttack { get; private set; }
        public int BonusDefense { get; private set; }
        public int BonusHitPoints { get; private set; }
        public int BonusAttackSpeed { get; private set; }
        public int BonusAccuracy { get; private set; }
        public int BonusEvasion { get; private set; }
        public ItemType Type { get; private set; }
        public string Name { get; private set; }
        //public int SubType { get; private set; }
        public int BonusShieldDefense { get; private set; }
        public int BonusShieldDefenseRate { get; private set; }
        public int ExperienceModifier { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Name}");
            result.AppendLine($"{this.Type.ToString()}");
            if (BonusAttack > 0)
            {
                result.AppendLine($"Attack: {this.BonusAttack}");
            }
            if (BonusDefense > 0)
            {
                result.AppendLine($"Defense: {this.BonusDefense}");
            }
            if (BonusHitPoints > 0)
            {
                result.AppendLine($"Hit points: {this.BonusHitPoints}");
            }
            if (BonusAttackSpeed > 0)
            {
                result.AppendLine($"Attack speed: {this.BonusAttackSpeed}");
            }
            if (BonusAccuracy > 0)
            {
                result.AppendLine($"Accuracy: {this.BonusAccuracy}");
            }
            if (BonusEvasion > 0)
            {
                result.AppendLine($"Evasion: {this.BonusEvasion}");
            }
            if (BonusShieldDefense > 0)
            {
                result.AppendLine($"Shield defense: {this.BonusShieldDefense}");
            }
            if (BonusShieldDefenseRate > 0)
            {
                result.AppendLine($"Shield defense rate: {this.BonusShieldDefenseRate}");
            }
            if (ExperienceModifier > 0)
            {
                result.AppendLine($"Experience bonus: {this.ExperienceModifier}");
            }

            return result.ToString();
        }

        public BasicItem(string name,
                         BodyPositions bodyPosition,
                         ItemType type,
                         int bonusAttack = 0,
                         int bonusDefense = 0,
                         int bonusHitPoints = 0,
                         int bonusAttackSpeed = 0,
                         int bonusAccuracy = 0,
                         int bonusEvasion = 0,
                         int bonusShieldDefense = 0,
                         int bonusShieldDefenseRate = 0,
                         int experienceModifier = 0)
        {
            this.Name = name;
            this.BodyPosition = bodyPosition;
            this.Type = type;
            this.BonusAttack = bonusAttack;
            this.BonusDefense = bonusDefense;
            this.BonusHitPoints = bonusHitPoints;
            this.BonusAttackSpeed = bonusAttackSpeed;
            this.BonusAccuracy = bonusAccuracy;
            this.BonusEvasion = bonusEvasion;
            this.BonusShieldDefense = bonusShieldDefense;
            this.BonusShieldDefenseRate = bonusShieldDefenseRate;
        }
    }
}