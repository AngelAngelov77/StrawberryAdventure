namespace StrawberryAdventure
{
    public enum BodyPositions
    {
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

    public enum ItemPositions
    {
        Head = 0,
        Neck = 1,
        Body = 2,
        Leggings = 3,
        Feet = 4,
        LeftHand = 5,
        RightHand = 6,
        Shoulders = 7,
        LeftRing = 8,
        RightRing = 9,
        Hands = 10,
        Belt1 = 11,
        Belt2 = 12,
        Belt3 = 13,
        Belt4 = 14,
        Backpack1 = 15,
        Backpack2,
        Backpack3,
        Backpack4,
        Backpack5,
        Backpack6,
        Backpack7,
        Backpack8
    }
}