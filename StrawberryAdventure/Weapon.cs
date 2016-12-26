namespace StrawberryAdventure
{
    public class Weapon : BasicItem
    {
        public Weapon(string name,
                      int attack,
                      int attackSpeed,
                      int accuracy) : base(name, BodyPositions.RightHand, ItemType.Weapon, bonusAttack: attack, bonusAttackSpeed: attackSpeed, bonusAccuracy: accuracy)
        {

        }
    }
}