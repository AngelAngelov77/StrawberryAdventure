using System.Text;

namespace StrawberryAdventure
{
    public abstract class BasicItem
    {
        private int _id;
        public BodyPositions BodyPosition { get; private set; }
        public bool AnyOfBodyPositions { get; private set; }
        public int BonusAttack { get; private set; }
        public int BonusDefense { get; private set; }
        public int BonusHitPoints { get; private set; }
        public ItemType Type { get; private set; }
        public string Name { get; private set; }

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

            return result.ToString();
        }

        public BasicItem(string name,
                         BodyPositions bodyPosition,
                         ItemType type,
                         bool anyOfBodyPositions = true,
                         int bonusAttack = 0,
                         int bonusDefense = 0,
                         int bonusHitPoints = 0)
        {
            this.Name = name;
            BodyPosition = bodyPosition;
            AnyOfBodyPositions = anyOfBodyPositions;
            Type = type;
            BonusAttack = bonusAttack;
            BonusDefense = bonusDefense;
            BonusHitPoints = bonusHitPoints;
        }
    }
}
