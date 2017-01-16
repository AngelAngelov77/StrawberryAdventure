namespace StrawberryAdventure
{
    public class Leggings : BasicItem
    {
        public Leggings(string name, int defense,int hitPoints) : base(name,BodyPositions.Leggings, ItemType.Armor,bonusDefense: defense,bonusHitPoints: hitPoints)
        {
        }
        
    }
}