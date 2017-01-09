namespace StrawberryAdventure
{
    public class Boots : BasicItem
    {
        public Boots(string name,
                     int defense) : base(name,
                                         BodyPositions.Feet,
                                         ItemType.Armor,
                                         bonusDefense: defense)
        {

        }
    }
}