namespace StrawberryAdventure
{
    public class Armor : BasicItem
    {
        public Armor(string name,int defense,int hitPoints) : base(name,BodyPositions.Body,ItemType.Armor,bonusDefense: defense,bonusHitPoints: hitPoints)
        {
        }
    }
}