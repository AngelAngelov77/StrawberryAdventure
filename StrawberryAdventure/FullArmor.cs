namespace StrawberryAdventure
{
    public class FullArmor : BasicItem
    {
        public FullArmor(string name,
                         int defense,
                         int hitPoints,
                         int accuracy,
                         int evasion,
                         int experience) : base(name, BodyPositions.FullArmor, ItemType.Armor, bonusDefense: defense, bonusHitPoints: hitPoints,
                                                bonusAccuracy: accuracy, bonusEvasion: evasion, experienceModifier: experience)
        {

        }
    }
}