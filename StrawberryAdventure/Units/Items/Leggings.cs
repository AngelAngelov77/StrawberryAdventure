namespace StrawberryAdventure
{
    public class LeggingsArmor : BasicItem
    {
        public LeggingsArmor(string name,
                             int defense,
                             int hitPoints) : base(name,
                                                 BodyPositions.Leggings,
                                                 ItemType.Armor,
                                                 bonusDefense: defense,
                                                 bonusHitPoints: hitPoints)
        {

        }
    }
}