namespace StrawberryAdventure
{
    public class Weapon : BasicItem
    {
        public Weapon(string name,
                      int attack,
                      int accuracy) : base(name, BodyPositions.RightHand, 
                                           ItemType.Weapon,
                                           bonusAttack: attack,
                                           bonusAccuracy: accuracy)
        {

        }
    }
}