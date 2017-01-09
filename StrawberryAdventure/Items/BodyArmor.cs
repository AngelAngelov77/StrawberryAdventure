namespace StrawberryAdventure
{
    public class BodyArmor : BasicItem
    {
        public BodyArmor(string name,
                         int defense,
                         int hitPoints) : base(name,
                                                BodyPositions.Body,
                                                ItemType.Armor,
                                                bonusDefense: defense,
                                                bonusHitPoints: hitPoints)
        {

        }
    }
}