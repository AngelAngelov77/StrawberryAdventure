namespace StrawberryAdventure
{
    public enum BodyPositions
    {
        None = 0,
        Head = 1,
        Neck = 2,
        Body = 4,
        Leggings = 8,
        Feet = 16,
        LeftHand = 32,
        RightHand = 64,
        Shoulders = 128,
        LeftRing = 256,
        RightRing = 512,
        Belt = 1024,
        Hands = 2048,
        Backpack = 4096,
        Rings = LeftRing | RightRing
    }
}