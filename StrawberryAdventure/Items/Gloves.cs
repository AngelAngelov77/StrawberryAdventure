namespace StrawberryAdventure
{
    public class Gloves : BasicItem
    {
        public Gloves(string name,
                      int defense,
                      int accuracy) : base(name,
                                           BodyPositions.Hands,
                                           ItemType.Armor,
                                           bonusDefense: defense,
                                           bonusAccuracy: accuracy)
        {

        }
    }
}