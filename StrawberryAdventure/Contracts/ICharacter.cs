namespace StrawberryAdventure
{
    interface ICharacter : IIdentifiable
    {
        string Name { get; }
        int Attack { get; }
        int Defense { get; }
        int Accuracy { get; }
        int HitPoints { get; }
        int Evasion { get; }
        int ChestUnlockSkill { get; }
    }
}
