namespace StrawberryAdventure
{
    public interface ICharacter : IIdentifiable
    {
        string Name { get; }

        int Attack { get; }

        int Defense { get; }

        int HitPoints { get; }
    }
}
