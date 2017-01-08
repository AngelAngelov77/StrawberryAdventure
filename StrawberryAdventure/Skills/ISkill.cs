namespace StrawberryAdventure
{
    interface ISkill
    {
        int ExperienceModifier { get; }
        int AttackBonus { get; }
        int DefenseBonus { get; }
        int AccuracyBonus { get; }
        int HitPointsBonus { get; }
        int EvasionBonus { get; }
        int ChestUnlockLevel { get; }
    }
}
