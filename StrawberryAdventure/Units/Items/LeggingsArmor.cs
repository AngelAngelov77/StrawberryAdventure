namespace StrawberryAdventure
{
    public class LeggingsArmor : BasicItem
    {
        public LeggingsArmor(string name,
                             int defense,
                             int hitPoints,
                             int accuracy,
                             int evasion) : base(name,
                                                 BodyPositions.Leggings,
                                                 ItemType.Armor,
                                                 bonusDefense: defense,
                                                 bonusAccuracy: accuracy,
                                                 bonusEvasion: evasion,
                                                 bonusHitPoints: hitPoints)
        {

        }
    }
}