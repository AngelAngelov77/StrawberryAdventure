namespace StrawberryAdventure
{
    public class Weapon : BasicItem
    {
        public Weapon(string name,
                      int attack) : base(name, BodyPositions.RightHand, 
                                           ItemType.Weapon,
                                           bonusAttack: attack)
        {

        }
    }
}