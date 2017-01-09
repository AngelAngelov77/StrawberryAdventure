namespace StrawberryAdventure
{
    public class Gloves : BasicItem
    {
        public Gloves(string name,
                      int defense) : base(name,
                                           BodyPositions.Hands,
                                           ItemType.Armor,
                                           bonusDefense: defense)
        {

        }
    }
}