namespace StrawberryAdventure
{
    public class Boots : BasicItem
    {
        public Boots(string name,
                     int defense,
                     int evasion) : base(name, BodyPositions.Feet, ItemType.Armor, bonusDefense: defense, bonusEvasion: evasion)
        {

        }
    }
}