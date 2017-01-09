using System.Text;

namespace StrawberryAdventure
{
    public abstract class BasicItem : IIdentifiable
    {
        private int _id;
        public BodyPositions BodyPosition { get; private set; }
        public bool AnyOfBodyPositions { get; private set; }
        public int BonusAttack { get; private set; }
        public int BonusDefense { get; private set; }
        public int BonusHitPoints { get; private set; }
        public int BonusAccuracy { get; private set; }
        public int BonusEvasion { get; private set; }
        public ItemType Type { get; private set; }
        public string Name { get; private set; }
        public int ExperienceModifier { get; private set; }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{Name}");
            result.AppendLine($"{Type.ToString()}");
            if (BonusAttack > 0)
            {
                result.AppendLine($"Attack: {BonusAttack}");
            }
            if (BonusDefense > 0)
            {
                result.AppendLine($"Defense: {BonusDefense}");
            }
            if (BonusHitPoints > 0)
            {
                result.AppendLine($"Hit points: {BonusHitPoints}");
            }
            if (BonusAccuracy > 0)
            {
                result.AppendLine($"Accuracy: {BonusAccuracy}");
            }
            if (BonusEvasion > 0)
            {
                result.AppendLine($"Evasion: {BonusEvasion}");
            }
            if (ExperienceModifier > 0)
            {
                result.AppendLine($"Experience bonus: {ExperienceModifier}");
            }

            return result.ToString();
        }

        public BasicItem(string name,
                         BodyPositions bodyPosition,
                         ItemType type,
                         bool anyOfBodyPositions = true,
                         int bonusAttack = 0,
                         int bonusDefense = 0,
                         int bonusHitPoints = 0,
                         int bonusAccuracy = 0,
                         int bonusEvasion = 0,
                         int experienceModifier = 0)
        {
            Name = name;
            BodyPosition = bodyPosition;
            AnyOfBodyPositions = anyOfBodyPositions;
            Type = type;
            BonusAttack = bonusAttack;
            BonusDefense = bonusDefense;
            BonusHitPoints = bonusHitPoints;
            BonusAccuracy = bonusAccuracy;
            BonusEvasion = bonusEvasion;
        }
    }
}
