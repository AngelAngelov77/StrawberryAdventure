namespace StrawberryAdventure
{
    public class Helmet : BasicItem
    {
        public Helmet(string name,
                      int defense,
                      int hitPoints) : base(name,
                                            BodyPositions.Head,
                                            ItemType.Armor,
                                            bonusDefense: defense,
                                            bonusHitPoints: hitPoints)
        {

        }
    }
}