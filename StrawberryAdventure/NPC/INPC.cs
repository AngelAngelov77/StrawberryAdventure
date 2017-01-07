namespace StrawberryAdventure
{
    public interface INPC
    {
        int Experience { get; }
        ItemsDrop[] DroppingItems { get; }
        BodyPositions BodyPositions { get; }
    }
}