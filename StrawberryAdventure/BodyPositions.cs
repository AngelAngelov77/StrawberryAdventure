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
        Backpack = 2048,
        Hands = 4096,
        Humanoid = Head + Neck + Body + Leggings + Feet + LeftHand + RightHand + Shoulders + LeftRing + RightRing,
        Hero = Humanoid + Belt + Backpack,
        Insect = Head + Body,
        Animal = Head + Body + Feet,
        FullArmor = Body + Leggings,
        Rings = LeftRing + RightRing
    }
}