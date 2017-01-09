namespace StrawberryAdventure
{
    public class Necklace : BasicItem
    {
        public Necklace(string name,
                      int hitPoints) : base(name, BodyPositions.Neck,
                                             ItemType.Jewel,
                                             bonusHitPoints: hitPoints)
        {

        }
    }
}