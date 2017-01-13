namespace StrawberryAdventure
{
    public class Ring : BasicItem
    {
        public Ring(string name,int hitPoints) : base(name, BodyPositions.Fingers,ItemType.Jewel,bonusHitPoints: hitPoints)
        {
        }
        
    }
}
